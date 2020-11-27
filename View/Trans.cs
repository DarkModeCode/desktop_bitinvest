using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_bitinvest_v1.View
{
    public partial class Trans : Form
    {
        public Trans()
        {
            InitializeComponent();
        }

        private void Trans_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.Moedas'. Você pode movê-la ou removê-la conforme necessário.
            this.moedasTableAdapter.Fill(this.bit_investDataSet1.Moedas);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.Transacao'. Você pode movê-la ou removê-la conforme necessário.
            this.transacaoTableAdapter.Fill(this.bit_investDataSet1.Transacao);
            // this.usuariosTableAdapter.Fill(this.bit_investDataSet1.Usuarios);
            //this.consultar_transacoesTableAdapter.Fill(this.bit_investDataSet1.consultar_transacoes);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.consultar_transacoesTableAdapter.FillBy(this.bit_investDataSet1.consultar_transacoes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

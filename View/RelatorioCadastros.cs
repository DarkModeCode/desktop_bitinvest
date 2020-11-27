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
    public partial class RelatorioCadastros : Form
    {
        public RelatorioCadastros()
        {
            InitializeComponent();
        }

        private void RelatorioCadastros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.bit_investDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.Moedas'. Você pode movê-la ou removê-la conforme necessário.
            this.moedasTableAdapter.Fill(this.bit_investDataSet1.Moedas);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.Transacao'. Você pode movê-la ou removê-la conforme necessário.
            this.transacaoTableAdapter.Fill(this.bit_investDataSet1.Transacao);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet11.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bit_investDataSet11.Perfil);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet11.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bit_investDataSet11.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.consultar_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.repviCadastros.RefreshReport();
        }
    }
}

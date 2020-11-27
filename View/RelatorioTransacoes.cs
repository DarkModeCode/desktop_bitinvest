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
    public partial class RelatorioTransacoes : Form
    {
        public RelatorioTransacoes()
        {
            InitializeComponent();
        }

        private void RelatorioTransacoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.Transacao'. Você pode movê-la ou removê-la conforme necessário.
            this.transacaoTableAdapter.Fill(this.bit_investDataSet1.Transacao);

            this.repviTransacoes.RefreshReport();
        }
    }
}

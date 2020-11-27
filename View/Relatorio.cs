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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            RelatorioCadastros frmReCad = new RelatorioCadastros();
            RelatorioTransacoes frmReTran = new RelatorioTransacoes();



            var tipoRelatorio = this.cboTipoRelatorio.SelectedItem;

            if (tipoRelatorio == "                RELATÓRIO DE TRANSAÇÕES")
            {
                if (frmReTran.Visible == true)
                {
                    frmReTran.Visible = false;
                }
                RelatorioTransacoes frm = new RelatorioTransacoes()
                {
                    TopLevel = false,
                };

                this.pnlRelatorio.Controls.Add(frm);

                frm.Show();
                frm.BringToFront();
            }
            else if (tipoRelatorio == "              RELATÓRIO DE CADASTROS")
            {
                if (frmReCad.Visible == true)
                {
                    frmReCad.Visible = false;
                }

                RelatorioCadastros frm = new RelatorioCadastros()
                {
                    TopLevel = false,
                };

                this.pnlRelatorio.Controls.Add(frm);

                frm.Show();
                frm.BringToFront();
            }
        }
    }
}

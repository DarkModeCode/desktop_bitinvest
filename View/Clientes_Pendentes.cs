using desktop_bitinvest_v1.Model;
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
    public partial class Clientes_Pendentes : Form
    {
        public Clientes_Pendentes()
        {
            InitializeComponent();
        }

        private void btnExibitDados_Click(object sender, EventArgs e)
        {
            UsuarioModel usuario = new UsuarioModel();
            dataTabelaClientesPendentes.DataSource = usuario.SelecionarClientesPendetes();

        }
    }
}

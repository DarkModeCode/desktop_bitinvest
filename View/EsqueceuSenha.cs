using desktop_bitinvest_v1.Controller;
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
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void bntConfirmarCod_Click(object sender, EventArgs e)
        {
            UsuarioModel usuario = new UsuarioModel();

            int cod = Convert.ToInt32(txtCodigo.Text);
            var codigoValido =  usuario.ConfirmarCod(Usuario.Id, cod);

            if (codigoValido == true)
            {
                EsqueceuSenha_RedefinindoSenha novaSenha = new EsqueceuSenha_RedefinindoSenha();
                novaSenha.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Codigo errado");
            }
        }
    }
}

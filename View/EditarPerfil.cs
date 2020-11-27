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
    public partial class EditarPerfil : Form
    {
        public EditarPerfil()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntSalvarAlterações_Click(object sender, EventArgs e)
        {
            UsuarioModel user = new UsuarioModel();
            user.AtualizarFuncionario(Funcionario.Id, textBox8.Text, textBox9.Text, textBox7.Text);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            txtNome.Text = Funcionario.Nome;
            textBox2.Text = Funcionario.Sobrenome;
            textBox3.Text = Funcionario.Data_nasc;
            textBox4.Text = Funcionario.cpf;
            textBox5.Text = Funcionario.rg;
            textBox6.Text = Funcionario.CargoNome;
            textBox7.Text = Funcionario.celular;
            textBox8.Text = Funcionario.telefone_residencial;
            textBox9.Text = Funcionario.Email;

           

        }
    }
}

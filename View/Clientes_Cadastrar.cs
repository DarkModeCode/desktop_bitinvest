using desktop_bitinvest_v1.Controller;
using desktop_bitinvest_v1.Model;
using desktop_bitinvest_v1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_bitinvest_v1
{
    public partial class Clientes_Cadastrar : Form
    {
        public Clientes_Cadastrar()
        {
            InitializeComponent();
        }
        private void Clientes_Cadastrar_Load(object sender, System.EventArgs e)
        {
            guna2Button1.Hide();
            bntCadastrar.Hide();
        } 
        private void CadastroPessoaFisica_Load(object sender, System.EventArgs e)
        {
            guna2Button1.Show();
            bntCadastrar.Show();
        }
        private void mskCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var tipoPessoa =  this.cboTipoPessoa.SelectedItem;

            if (tipoPessoa == "               PESSOA FÍSICA") {
                CadastroPessoaFisica frm = new CadastroPessoaFisica()
                {
                    TopLevel = false,
                };

                this.panel2.Controls.Add(frm);

                frm.Show();
                frm.BringToFront();
            }
            else if (tipoPessoa == "             PESSOA JURÍDICA")
            {
                CadastroPessoaJuridica frm = new CadastroPessoaJuridica()
                {
                    TopLevel = false,
                };

                this.panel2.Controls.Add(frm);

                frm.Show();
                frm.BringToFront();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

            private void bntCadastrar_Click(object sender, EventArgs e)
        {
         UsuarioModel user = new UsuarioModel();
            //oiiii
            var tipoPessoa = this.cboTipoPessoa.SelectedItem;

            if (tipoPessoa == "               PESSOA FÍSICA")
            {
                var perfil = 4;
                var cadastro = user.CadastrarCliente(Cliente.Nome, Cliente.Email, Cliente.Senha, Cliente.Data_nasc_fund, Cliente.Sobrenome, Cliente.rg, Cliente.cpf_cnpj, Cliente.telefone_residencial,
       Cliente.celular, Cliente.Foto_Frente, Cliente.Foto_Tras, Cliente.Foto_Selfie, Cliente.RendaMensal, perfil,Cliente.Rua,Cliente.Bairro,Cliente.Complemento,Cliente.Cidade,Cliente.Numero,Cliente.Estado,Cliente.Pais, Cliente.Cep);
               MessageBox.Show("Cadastrado com Sucesso!");
              
            }
            else if (tipoPessoa == "             PESSOA JURÍDICA")
            {
                var nulo = "Nulo";
                var perfil = 5;
                var cadastro = user.CadastrarCliente(Cliente.Nome, Cliente.Email, Cliente.Senha, Cliente.Data_nasc_fund, Cliente.Sobrenome, nulo, Cliente.cpf_cnpj, Cliente.telefone_residencial,
       nulo, Cliente.Foto_Frente, Cliente.Foto_Tras, Cliente.Foto_Selfie, nulo, perfil, Cliente.Rua, Cliente.Bairro, Cliente.Complemento, Cliente.Cidade, Cliente.Numero, Cliente.Estado, Cliente.Pais, Cliente.Cep);
               MessageBox.Show("Cadastrado com Sucesso!");
               

            }
            
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pnlCadCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

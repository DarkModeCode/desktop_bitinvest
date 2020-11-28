using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using desktop_bitinvest_v1.Controller;
using desktop_bitinvest_v1.Model;
using desktop_bitinvest_v1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = Amazon.SimpleEmail.Model.Message;

namespace desktop_bitinvest_v1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "Email" && txtEmail.TextLength > 2)
            {
                if (txtSenha.Text != "Senha")
                {
                    UsuarioModel user = new UsuarioModel();
                    var validLogin = user.LoginUser(txtEmail.Text, txtSenha.Text);
                    
                    if (validLogin == true)
                    {
                //verifica se o usuario é funcionario e abre as funções de funcionario
                if (Usuario.id_perfil == 3){
                            MessageBox.Show("Usuario sem permissão");
                           
                     }
                        //verifica se o usuario é cliente se for nega acesso
                        else{
                            user.SelecionarFuncionario(Funcionario.Id);

                            Home mainMenu = new Home();
                            mainMenu.Show();
                            this.Hide();
                        }
                                               
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha errado. \n   Tente novamente.");
                        txtSenha.Text = "Password";
                        txtEmail.UseSystemPasswordChar = false;
                        txtEmail.Focus();
                    }
                }
                else MessageBox.Show("Por favor entre uma senha.");
            }
            else MessageBox.Show("Por favor entre um email.");
        }

        private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtEmail != null)
            {
                UsuarioModel usuario = new UsuarioModel();
                var email = usuario.Email(txtEmail.Text);
                if (email == true)
                {
                    Random ran = new Random();
                    int cod = ran.Next(1000, 9999);


                    usuario.Esqueci(Usuario.Id, cod);
                    SmtpClient client = new SmtpClient();
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("contato@bitinvestimentos.com.br", "69634270");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;

                    try
                    {
                        MailAddress maFrom = new MailAddress("contato@bitinvestimentos.com.br", "Bit Invest", Encoding.UTF8);
                        MailAddress maTo = new MailAddress(txtEmail.Text, " ", Encoding.UTF8);
                        MailMessage mmsg = new MailMessage(maFrom, maTo);
                        mmsg.Body = "Olá, seu codigo é " + cod;
                        mmsg.BodyEncoding = Encoding.UTF8;
                        mmsg.IsBodyHtml = true;
                        mmsg.Subject = "Codigo de esqueceu a senha";
                        mmsg.SubjectEncoding = Encoding.UTF8;

                        client.Send(mmsg);
                        MessageBox.Show("Codigo Enviado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), ex.Message);
                        //throw;
                    }
                    EsqueceuSenha formEsqueceu = new EsqueceuSenha();

                    formEsqueceu.Show();
                }
                else
                {

                    MessageBox.Show("Email não cadastrado");
                }
            }
            else {
                MessageBox.Show("Insira um email");
            }
        }
    }
}

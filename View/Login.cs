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
                        Home mainMenu = new Home();
                        mainMenu.Show();
                        this.Hide();
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

        private async void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
            {
                smtp.Host = "localhost";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Timeout = 50000;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential("bit.investimentos2020@gmail.com", "25102020BI.");

                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new System.Net.Mail.MailAddress("bit.investimentos2020@gmail.com");

                    if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        mail.To.Add(new System.Net.Mail.MailAddress(txtEmail.Text));
                    }
                    else
                    {
                        MessageBox.Show("Campo 'para' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    UsuarioModel user = new UsuarioModel();
                    var validLogin = user.Email(txtEmail.Text);
                    mail.Subject = "noReply";
                    mail.Body = "Sua senha é " + Usuario.Senha;
                    await smtp.SendMailAsync(mail);
                }
            }
        }

    }
}

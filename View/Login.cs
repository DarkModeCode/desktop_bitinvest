﻿using Amazon;
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
                    UnicodeEncoding UE = new UnicodeEncoding();
                    byte[] HashValue, MessageBytes = UE.GetBytes(txtSenha.Text);
                    SHA1Managed SHhash = new SHA1Managed();
                    string strHex = "";
                    HashValue = SHhash.ComputeHash(MessageBytes);
                    foreach (byte b in HashValue)

                    {
                        strHex += String.Format("{0:x2}", b);

                    }
                    UsuarioModel user = new UsuarioModel();
                    var validLogin = user.LoginUser(txtEmail.Text, strHex);
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

        private  void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Random ran = new Random();
            int cod = ran.Next(1000,9999);

        UsuarioModel usuario = new UsuarioModel();
            usuario.Email(txtEmail.Text);
            usuario.Esqueci(Usuario.Id, cod);
            EsqueceuSenha formEsqueceu = new EsqueceuSenha();
            formEsqueceu.Show();
           // this.Close();

            //Remember to enter your (AWSAccessKeyID, AWSSecretAccessKey) if not using and IAM User with credentials assigned to your instance and your RegionEndpoint
            /* using (var client = new AmazonSimpleEmailServiceClient("AKIAIY6P3I3S2TK2UZKA", "nVAtJH2PYHcwIERlDx41J/EZZWKYTd7lwMANv3BU", RegionEndpoint.USEast1))
             {
                 var emailRequest = new SendEmailRequest()
                 {
                     Source = "FROMADDRESS@TEST.COM",
                     Destination = new Destination(),
                     Message = new Message()
                 };

                 emailRequest.Destination.ToAddresses.Add(txtEmail.Text);
                 emailRequest.Message.Subject = new Content("Hello World");
                 emailRequest.Message.Body = new Body(new Content("Hello World"));
                 client.SendEmail(emailRequest);
             } */
        }

    }
}

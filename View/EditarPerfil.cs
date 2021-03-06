﻿using desktop_bitinvest_v1.Controller;
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
            if (textBox1.Text == Funcionario.Senha)
            {
                if (textBox1.Text == textBox11.Text)
                {

                    user.AtualizarFuncionario(Funcionario.Id, textBox8.Text, textBox9.Text, textBox7.Text);

                }
                else
                {
                    MessageBox.Show("As senhas não são iguais.");
                }
            }
            else
            {
                MessageBox.Show("É preciso preencher a senha para alterar os dados");

            }
            if (textBox10.TextLength > 0)
            {
                if (textBox10.TextLength > 7)
                {
                    if (textBox1.Text == Funcionario.Senha)
                    {
                        if (textBox1.Text == textBox11.Text)
                        {
                            UsuarioModel usuario = new UsuarioModel();
                            usuario.Atualizar_senha(Usuario.Id, textBox10.Text);
                        }
                        else
                        {
                            MessageBox.Show("As senhas não são iguais.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("É preciso preencher a senha para alterar os dados");

                    }
                }
                else
                {

                    MessageBox.Show("A senha precisa ter 8 caracteres");

                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            txtNome.Text =  Funcionario.Nome;
            textBox2.Text = Funcionario.Sobrenome;
            textBox3.Text = Funcionario.Data_nasc;
            textBox4.Text = Funcionario.cpf;
            textBox5.Text = Funcionario.rg;
            textBox6.Text = Funcionario.CargoNome;
            textBox7.Text = Funcionario.celular;
            textBox8.Text = Funcionario.telefone_residencial;
            textBox9.Text = Funcionario.Email;

           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Funcionario.SenhaNova = textBox10.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntSalvarSenhaNova_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class EsqueceuSenha_RedefinindoSenha : Form
    {
        public EsqueceuSenha_RedefinindoSenha()
        {
            InitializeComponent();
        }

        private void bntConfirmarSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.TextLength > 7)
            {
                if (txtNovaSenha.Text == txtNovaSenhaConfirmar.Text)
                {
                    UsuarioModel usuario = new UsuarioModel();
                    usuario.Atualizar_senha(Usuario.Id, txtNovaSenha.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("As senhas não são iguais.");
                }
            }
            else {

                MessageBox.Show("A senha precisa ter 8 caracteres");

            }
        }
    }
}

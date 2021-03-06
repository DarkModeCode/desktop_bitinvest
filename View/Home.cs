﻿using desktop_bitinvest_v1.Controller;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizeMenu();
            bntFuncionarios.Hide();
            if (Usuario.id_perfil == 1) {
                bntFuncionarios.Show();
            }

        }

        #region Slide menu
        private void customizeMenu()
        {
            pnlSubClientes.Visible = false;
            pnlSubFunc.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubClientes.Visible == true)
                pnlSubClientes.Visible = false;

            if (pnlSubFunc.Visible == true)
                pnlSubFunc.Visible = false;
        }

        private void showSubMenu (Panel pnlSubClientes)
        {
            if (pnlSubClientes.Visible == false)
            {
                hideSubMenu();
                pnlSubClientes.Visible = true;
            }
            else
                pnlSubClientes.Visible = false;
        }
        private void bntClientes_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlSubClientes);
        }
        #endregion

        #region Sub Menus
        private void bntClientes_Click_2(object sender, EventArgs e)
        {
            #region Cores 
            //este código define as cores dos botões selecionados ou não
            if (bntClientes.Normalcolor == Color.FromArgb(62, 63, 77))
            {
                bntClientes.Normalcolor = Color.FromArgb(31, 31, 38);
            }
            else if (bntClientes.Normalcolor == Color.FromArgb(31, 31, 38))
            {
                bntClientes.Normalcolor = Color.FromArgb(62, 63, 77);
            } 
            #endregion
            showSubMenu(pnlSubClientes);
        }

        private void bntFuncionarios_Click_1(object sender, EventArgs e)
        {
            #region Cores
            if (bntFuncionarios.Normalcolor == Color.FromArgb(62, 63, 77))
            {
                bntFuncionarios.Normalcolor = Color.FromArgb(31, 31, 38);
            }
            else if (bntFuncionarios.Normalcolor == Color.FromArgb(31, 31, 38))
            {
                bntFuncionarios.Normalcolor = Color.FromArgb(62, 63, 77);
            }
            #endregion
            showSubMenu(pnlSubFunc);
        }
        #endregion

        #region Elementos
        private void lblEmail_Click(object sender, EventArgs e)
        {
            //Códigos
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Códigos
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Códigos
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //Códigos
        }

        private void bntClientes_Click(object sender, EventArgs e)
        {
            //Codigos
        }

        private void bntClienteConsultar_Click(object sender, EventArgs e)
        {
            //Codigos
        }

        private void bny_1(object sender, EventArgs e)
        {
            //Codigos
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //Codigos
        }
        private void bntFuncionarios_Click(object sender, EventArgs e)
        {
            //Codigos
        }
        #endregion

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlSubFunc);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            lblNome.Text = Usuario.NomeFun;
            lblFuncao.Text = Usuario.cargo;
        }


        #region Eventos dos botoes
        private void bntTransacoes_Click(object sender, EventArgs e)
        {
            Trans frm = new Trans()
            {
                TopLevel = false,
            };
            chamarForm(frm);
            hideSubMenu();
        }

        private void bntRelatorios_Click(object sender, EventArgs e)
        {
            Relatorio frm = new Relatorio()
            {
                TopLevel = false,
            };
            chamarForm(frm);
            hideSubMenu();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            Monitoramento frm = new Monitoramento()
            {
                TopLevel = false,
            };
            chamarForm(frm);
            hideSubMenu();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Chamando Forms
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes()
            {
                TopLevel = false,
            };
            chamarForm(frm);

        }
        public void chamarForm(Form frm) {

            this.panel3.Controls.Add(frm);

            frm.Show();
            frm.BringToFront();

            imgLogo.Hide();

        }  
        #endregion
        private void optSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntCadastrarCliente_Click(object sender, EventArgs e)
        {
            Clientes_Cadastrar frm = new Clientes_Cadastrar()
            {
                TopLevel = false,
            };
          
            chamarForm(frm);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntClientePendentes_Click(object sender, EventArgs e)
        {
            Clientes_Pendentes frm = new Clientes_Pendentes()
            {
                TopLevel = false,
            };

            chamarForm(frm);
        }

        private void hover(object sender, EventArgs e)
        {

        }

        private void enter(object sender, EventArgs e)
        {

        }

        private void picCadastrarCli_Click(object sender, EventArgs e)
        {

        }
        private void leave(object sender, EventArgs e)
        {

        }

        private void picCadastrarFunc_Click(object sender, EventArgs e)
        {
                    }

        private void bntCadastrarFunc_Click(object sender, EventArgs e)
        {
            Funcionarios_Cadastrar frm = new Funcionarios_Cadastrar()
            {
                TopLevel = false,
            };

            chamarForm(frm);
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPerfil frm = new EditarPerfil()
            {
                TopLevel = false,
            };
            chamarForm(frm);

        }

        private void bntConsultarFunc_Click(object sender, EventArgs e)
        {
            Funcionários frm = new Funcionários()
            {
                TopLevel = false,
            };
            chamarForm(frm);
        }
    }
}

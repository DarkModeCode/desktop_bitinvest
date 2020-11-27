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
    public partial class Funcionários : Form
    {
        public Funcionários()
        {
            InitializeComponent();
        }

        private void Funcionários_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.consultar_funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.consultar_funcionarioTableAdapter.Fill(this.bit_investDataSet1.consultar_funcionario);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bit_investDataSet1.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.usuario_tem_perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.usuario_tem_perfilTableAdapter.Fill(this.bit_investDataSet1.usuario_tem_perfil);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.bit_investDataSet1.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'bit_investDataSet1.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bit_investDataSet1.Funcionario);

        }

        private void bitinvestDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataFuncionarios.Rows[e.RowIndex];

                var id = (int)row.Cells[0].Value;
                UsuarioModel user = new UsuarioModel();

                user.SelecionarFuncionario(id);

                EditarPerfil infos = new EditarPerfil();
                infos.Show();
                infos.BringToFront();

            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy(this.bit_investDataSet1.Usuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.funcionarioTableAdapter.FillBy(this.bit_investDataSet1.Funcionario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

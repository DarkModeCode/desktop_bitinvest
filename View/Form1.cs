using desktop_bitinvest_v1.Controller;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Funcionario.Nome;
            textBox2.Text = Funcionario.Sobrenome;
            textBox3.Text = Funcionario.Data_nasc;
            textBox4.Text = Funcionario.cpf;
            textBox5.Text = Funcionario.rg;
            textBox6.Text = Funcionario.CargoNome;
            textBox7.Text = Funcionario.celular;
            textBox8.Text = Funcionario.telefone_residencial;
            textBox9.Text = Funcionario.Email;
            textBox10.Text = Funcionario.Ferias;
            textBox11.Text = Funcionario.Horas_Trabalho;
            textBox12.Text = Funcionario.Obs;
            textBox13.Text = Funcionario.Numero;
            textBox14.Text = Funcionario.Pais;
            textBox15.Text = Funcionario.Pis_Paes;
            textBox16.Text = Funcionario.Rua;
            textBox17.Text = Funcionario.Salario;
            textBox18.Text = Funcionario.Senha;
            textBox19.Text = Funcionario.Tipo_Contrato;
            textBox20.Text = Funcionario.Admissao;
            textBox21.Text = Funcionario.Agencia;
            textBox22.Text = Funcionario.Bairro;
            var cod = Funcionario.Cod_banco.ToString();
            textBox23.Text = cod;
           textBox24.Text = Funcionario.Cep;
            textBox25.Text = Funcionario.Cidade;
            textBox26.Text = Funcionario.Complemento;
           textBox27.Text = Funcionario.Conta;
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

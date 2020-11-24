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
    public partial class Funcionarios_Cadastrar : Form
    {
        public Funcionarios_Cadastrar()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeFun_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Nome = txtNomeFun.Text;

        }

        private void txtSobrenomeFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Sobrenome = txtSobrenomeFunc.Text;

        }

        private void txtCpfFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.cpf = txtCpfFunc.Text;

        }

        private void mskRGFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Funcionario.rg = mskRGFunc.Text;

        }

        private void txtDataNascFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Data_nasc = txtDataNascFunc.Text;

        }

        private void mskCelularFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Funcionario.celular = mskCelularFunc.Text;

        }

        private void txtTelefoneFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.telefone_residencial = txtTelefoneFunc.Text;

        }

        private void txtEmailFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Email = txtEmailFunc.Text;

        }

        private void mskCepFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Funcionario.Cep = mskCepFunc.Text;

        }

        private void txtRuaFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Rua = txtRuaFunc.Text;
        }

        private void txtNumFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Numero = txtNumFunc.Text;

        }

        private void txtComplFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Complemento = txtComplFunc.Text;

        }

        private void txtBairroFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Bairro = txtBairroFunc.Text;

        }

        private void txtCidadeFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Cidade = txtCidadeFunc.Text;

        }

        private void txtEstadoFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Estado = txtEstadoFunc.Text;

        }

        private void txtPaisFunc_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Pais = txtPaisFunc.Text;

        }

        private void dropBanco_onItemSelected(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var banco = this.comboBox1.SelectedItem.ToString();

            if (banco == "Banco Santander Brasil")
            {
                Funcionario.Cod_banco = 1;

            }else if(banco == "Banco Itaú Unibanco")
            {
                Funcionario.Cod_banco = 2;

            }
            else if(banco == "Banco Bradesco")
            {
                Funcionario.Cod_banco = 3;

            } else if(banco == "Caixa Econômica Federal")
            {
                Funcionario.Cod_banco = 4;

            }else if(banco == "Banco do Brasil")
            {
                Funcionario.Cod_banco = 5;

            }else if(banco == "Nubank")
            {
                Funcionario.Cod_banco = 6;

            }else if(banco == "Banco Safra")
            {
                Funcionario.Cod_banco = 7;

            }else if(banco == "Banco BTG Pactual")
            {
                Funcionario.Cod_banco = 8;

            }else if(banco == "Sicoob")
            {
                Funcionario.Cod_banco = 9;

            }else if(banco == "Banco Votorantim")
            {
                Funcionario.Cod_banco = 10;

            }else if(banco == "Citibank Brasil")
            {
                Funcionario.Cod_banco = 12;

            }else if(banco == "Banrisul")
            {
                Funcionario.Cod_banco = 11;

            }
        }

        private void txtAgencia_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Agencia = txtAgencia.Text ;

        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Conta = txtConta.Text;
        }

        private void dropCargo_onItemSelected(object sender, EventArgs e)
        {

        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cargo = this.cmbCargo.SelectedItem.ToString();

            if (cargo == "Gerente")
            {
                Funcionario.Cargo = 1;

            }
            else if (cargo == "Analista de sistemas")
            {
                Funcionario.Cargo = 2;

            }else if (cargo == "Analista de negocios")
            {
                Funcionario.Cargo = 3;

            }else if (cargo == "Analista Administrativo")
            {
                Funcionario.Cargo = 4;

            }else if (cargo == "Coordenador")
            {
                Funcionario.Cargo = 5;

            }else if (cargo == "Estagiario")
            {
                Funcionario.Cargo = 6;

            }
        }

        private void txtTipoContrato_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Tipo_Contrato = txtTipoContrato.Text;

        }

        private void txtCTPS_TextChanged(object sender, EventArgs e)
        {
            Funcionario.CTPS = txtCTPS.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Dias_Trabalho = textBox2.Text;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Horas_Trabalho = textBox1.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Ferias = textBox3.Text;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Salario = textBox4.Text;

        }

        private void bntAvançar_Click(object sender, EventArgs e)
        {
            Funcionarios_Cadastrar_Obs frmObs = new Funcionarios_Cadastrar_Obs();
            this.Close();
            frmObs.Show();
        }

        private void txtPis_Paes_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Pis_Paes = txtPis_Paes.Text;

        }

        private void txtAdmissao_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Admissao = txtAdmissao.Text;

        }
    }
}
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
    public partial class Funcionarios_Cadastrar_Obs : Form
    {
        public Funcionarios_Cadastrar_Obs()
        {
            InitializeComponent();
        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {
            Funcionario.Obs = txtObs.Text;
        }
        private void limparVariaveis()
        {

            Funcionario.Nome = null; Funcionario.Email = null; Funcionario.Senha = null;
            Funcionario.Data_nasc = null; Funcionario.Sobrenome = null; Funcionario.rg = null;
            Funcionario.cpf = null; Funcionario.celular = null; Funcionario.Rua = null; Funcionario.Bairro = null; Funcionario.Complemento = null;
            Funcionario.Cidade = null; Funcionario.Numero = null; Funcionario.Estado = null;
            Funcionario.Pais = null; Funcionario.Cep = null;

        }

        private void bntCadastrarFunc_Click(object sender, EventArgs e)
        {
            UsuarioModel user = new UsuarioModel();
            int perfil = 2;
            var nulo = "nulo";
            var cadastro = user.CadastrarFuncionarios(
                Funcionario.Nome, Funcionario.Email, Funcionario.cpf, Funcionario.Data_nasc, Funcionario.Sobrenome, Funcionario.rg, Funcionario.cpf, Funcionario.telefone_residencial,
                Funcionario.celular, Funcionario.CTPS, nulo, Funcionario.Salario, Funcionario.Horas_Trabalho, Funcionario.Ferias, Funcionario.Pis_Paes, Funcionario.Obs, Funcionario.Admissao, Funcionario.Tipo_Contrato, Funcionario.Dias_Trabalho,
               Funcionario.Cargo, perfil,Funcionario.Rua, Funcionario.Bairro, Funcionario.Complemento, Funcionario.Cidade, Funcionario.Numero, Funcionario.Estado, Funcionario.Pais, Funcionario.Cep,
                Funcionario.Conta, Funcionario.Agencia, Funcionario.Cod_banco
                );
            MessageBox.Show("Cadastrado com Sucesso!");
            limparVariaveis();
        }
    }
}

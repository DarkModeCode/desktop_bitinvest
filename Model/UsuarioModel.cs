using desktop_bitinvest_v1.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_bitinvest_v1.Model
{

    public class UsuarioModel
    {
        UsuarioDAO userDao = new UsuarioDAO();
        public bool LoginUser(string email, string senha)
        {
            return userDao.Login(email, senha);
        }
        public bool CadastrarCliente(string nome, string email, string senha, string data_nasc_fund,  string sobrenome, string rg, string cpf_cnpj, string telefone_residencial,
        string celular, byte[] foto_doc_frente, byte[] foto_doc_tras, byte[] foto_doc_selfie, string renda_mensal, int tipo_pessoa, string rua, string bairro, string complemento, string cidade, string numero, string estado, string pais, string cep
           )
        {
            return userDao.CadastrarClientes( nome,  email,  senha,  data_nasc_fund,  sobrenome,  rg,  cpf_cnpj,  telefone_residencial,
         celular, foto_doc_frente,  foto_doc_tras,  foto_doc_selfie,  renda_mensal,  tipo_pessoa, rua, bairro, complemento, cidade, numero, estado, pais, cep
           );
        }
        public bool CadastrarClienteJuridico(string nome, string email, string senha, string data_nasc_fund,  string sobrenome, string rg, string cpf_cnpj, string telefone_residencial,
        string celular, int tipo_pessoa, string rua, string bairro, string complemento, string cidade, string numero, string estado, string pais, string cep
           )
        {
            return userDao.CadastrarClientesJuridico( nome,  email,  senha,  data_nasc_fund,  sobrenome,  rg,  cpf_cnpj,  telefone_residencial,
         celular, tipo_pessoa, rua, bairro, complemento, cidade, numero, estado, pais, cep
           );
        }
        
        public bool CadastrarFuncionarios(string nome, string email, string senha, string data_nasc_fund, string sobrenome, string rg, string cpf_cnpj, string telefone_residencial,
            string celular, string CTPS, string data_de_demissao, string salario, string horario_de_trabalho, string concessao_de_ferias,
string pis_paes, string obs, string data_de_admissao, string tipo_contrato, string dias_de_trabalho,
int id_cargo, int id_perfil, string rua, string bairro, string complemento, string cidade, string numero, string estado, string pais, string cep, string n_conta_bancaria, string n_agencia, int cod_banco
                )
        {
            return userDao.CadastrarFuncionario( nome,  email,  senha,  data_nasc_fund,  sobrenome,  rg,  cpf_cnpj,  telefone_residencial,
             celular,  CTPS,  data_de_demissao,  salario,  horario_de_trabalho,  concessao_de_ferias, pis_paes,  obs,  data_de_admissao,  tipo_contrato,  dias_de_trabalho,
                id_cargo,  id_perfil,  rua,  bairro,  complemento,  cidade,  numero,  estado,  pais,  cep,  n_conta_bancaria,  n_agencia,  cod_banco);
        }

        public bool Email(string email)
        {
            return userDao.Email(email);
        }
        
        public bool ConfirmarCod(int id_usuario, int cod)
        {
            return userDao.ConfirmarCod(id_usuario, cod);
        }
        public bool Esqueci(int id_usuario,int cod)
        {
            return userDao.Esqueceu(id_usuario,cod);
        }

        public bool Atualizar_senha(int id_usuario, string senha)
        {
            return userDao.AtualizarSenha(id_usuario, senha);
        }
        public bool AtualizarCliente(int id_usuario, string senha, string renda_mensal, string telefone_residencial, string sobrenome, string nome, string rg, string cpf_cnpj, string email, string celular, string data_nasc_fund)
        {
            return userDao.AtualizarCliente(id_usuario, senha, renda_mensal, telefone_residencial,  sobrenome, nome, rg, cpf_cnpj, email, celular, data_nasc_fund);
        }
        public object SelecionarClientes() {

            return userDao.SelecionarClientes();
        }
        public object SelecionarFuncionario(int id) {

            return userDao.SelecionarFuncionario(id);
        }public bool AtualizarFuncionario(int id_usuario, string telefone_residencial, string email, string celular)
        {
            return userDao.AtualizarFuncionario(id_usuario, telefone_residencial, email, celular);
        }
        public object SelecionarClientesPendetes() {

            return userDao.SelecionarClientesPendentes();
        }

        public object Pesquisa(string id) {

            return userDao.Pesquisa(id);
        }

        public bool SelecionarLinhas(int id_usu)
        {
            return userDao.SelecionarLinha(id_usu);
        }
        
        public bool SelecionarTransacao(int id_usu)
        {
            return userDao.SelecionarTransacao(id_usu);
        }

        public bool SelecionarRealBit(int id_usu)
        {
            return userDao.SelecionarRealBit(id_usu);
        } 
        
        public bool SelecionarEthereum(int id_usu)
        {
            return userDao.SelecionarEthereum(id_usu);
        }
        public bool SelecionarBitcoin(int id_usu)
        {
            return userDao.SelecionarBitcoin(id_usu);
        }
        
        public bool SelecionarLitecoin(int id_usu)
        {
            return userDao.SelecionarLitecoin(id_usu);
        } 
        
        public bool SelecionarRealEt(int id_usu)
        {
            return userDao.SelecionarRealEt(id_usu);
        }
        public bool SelecionarRealLite(int id_usu)
        {
            return userDao.SelecionarRealLite(id_usu);
        }
    }
}

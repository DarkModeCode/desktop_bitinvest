using desktop_bitinvest_v1.Controller;
using System;
using System.Collections.Generic;
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

        public bool Email(string email)
        {
            return userDao.Email(email);
        }
        public object SelecionarClientes() {

            return userDao.SelecionarClientes();
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

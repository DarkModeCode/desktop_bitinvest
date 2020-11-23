using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace desktop_bitinvest_v1.Controller
{
    public class UsuarioDAO : Banco
    {
        public bool Login(string email, string senha)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "select * from usuarios where (email=@email and senha=@senha)";
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", senha);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                {
                 
                    Usuario.NomeFun = reader.GetString(3);
                

                }
                return true;
            }
            else
                return false;


        } 
        public bool ConfirmarCod(int id_usuario,int cod)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "select * from esqueci_senha where (id_usuario=@id_usuario and codigo=@codigo)";
            command.Parameters.AddWithValue("@id_usuario", id_usuario);
            command.Parameters.AddWithValue("@codigo", cod);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }

        public bool Email(string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id_usuario,email from usuarios where (email=@email)";
                    command.Parameters.AddWithValue("@email", email);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {
                            Usuario.Id = reader.GetInt32(0);
                            Usuario.Email = reader.GetString(1);

                        }
                        return true;
                    }
                    else
                    
                       
                        return false;
                    
                }
            }
        }

        public bool CadastrarClientes(string nome, string email, string senha, string data_nasc_fund, string sobrenome, string rg, string cpf_cnpj, string telefone_residencial,
        string celular, byte[] foto_doc_frente, byte[] foto_doc_tras, byte[] foto_doc_selfie, string renda_mensal, int tipo_pessoa, string rua, string bairro, string complemento, string cidade, string numero, string estado, string pais, string cep
            )
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(senha);
            SHA1Managed SHhash = new SHA1Managed();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)

            {
                strHex += String.Format("{0:x2}", b);

            }
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("inserir", connection);  //creating  SqlCommand  object  
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", nome);          
                    cmd.Parameters.AddWithValue("@email ", email);       
                    cmd.Parameters.AddWithValue("@senha ", strHex);
                    cmd.Parameters.AddWithValue("@sobrenome ", sobrenome);
                    cmd.Parameters.AddWithValue("@data_nasc_fund ", data_nasc_fund);
                    cmd.Parameters.AddWithValue("@rg ", rg);
                    cmd.Parameters.AddWithValue("@cpf_cnpj ", cpf_cnpj);
                    cmd.Parameters.AddWithValue("@telefone_residencial ", telefone_residencial);
                    cmd.Parameters.AddWithValue("@celular ", celular);
                    cmd.Parameters.AddWithValue("@foto_doc_frente ", foto_doc_frente);
                    cmd.Parameters.AddWithValue("@foto_doc_tras ", foto_doc_tras);
                    cmd.Parameters.AddWithValue("@foto_doc_selfie ", foto_doc_selfie); 
                    cmd.Parameters.AddWithValue("@renda_mensal ", renda_mensal);
                    cmd.Parameters.AddWithValue("@tipo_pessoa ", tipo_pessoa);
                    SqlCommand cmmd = new SqlCommand("inserir_endereco", connection);  //creating  SqlCommand  object  
                    cmmd.CommandType = CommandType.StoredProcedure;
                    cmmd.Parameters.AddWithValue("@rua", rua);
                    cmmd.Parameters.AddWithValue("@bairro", bairro);
                    cmmd.Parameters.AddWithValue("@complemento", complemento);
                    cmmd.Parameters.AddWithValue("@cidade", cidade);
                    cmmd.Parameters.AddWithValue("@numero", numero);
                    cmmd.Parameters.AddWithValue("@estado", estado);
                    cmmd.Parameters.AddWithValue("@pais", pais);
                    cmmd.Parameters.AddWithValue("@cep", pais);
                    cmd.ExecuteNonQuery();                     //executing the sqlcommand  
                    cmmd.ExecuteNonQuery();                     //executing the sqlcommand  

                  

                }

                return true;
            }
        }
        
        public bool AtualizarSenha(int id_usuario, string senha)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(senha);
            SHA1Managed SHhash = new SHA1Managed();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)

            {
                strHex += String.Format("{0:x2}", b);

            }
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("atualizar_senha", connection);  //creating  SqlCommand  object  
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario ", id_usuario);
                    cmd.Parameters.AddWithValue("@senha ", strHex);
                    cmd.ExecuteNonQuery();                     //executing the sqlcommand  
                }

                return true;
            }
        }

        public bool Esqueceu(int id_usuario, int cod)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("esqueci", connection);  //creating  SqlCommand  object  
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.Parameters.AddWithValue("@codigo", cod);
                    cmd.ExecuteNonQuery();                     //executing the sqlcommand  
                }

                return true;

            }
        }

        public DataSet SelecionarClientes()
        {
            using (var con = GetConnection())
            {
                con.Open();
                string query =  "select u.id_usuario as ID, u.nome as NOME, u.cpf_cnpj as CPF_CNPJ, u.rg as RG from usuarios u inner join cliente c on u.id_usuario=c.id_usuario;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet dtset = new DataSet();
                adapter.Fill(dtset);
                return dtset;
            }
        }public DataSet SelecionarClientesPendentes()
        {
            using (var con = GetConnection())
            {
                con.Open();
                string query =  "select data_nasc_fund, nome,cpf_cnpj ,rg from analise;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet dtset = new DataSet();
                adapter.Fill(dtset);
                return dtset;
            }
        }

        public bool SelecionarLinha(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select u.id_usuario, u.nome, u.cpf_cnpj, u.rg from usuarios u where u.id_usuario = @id_usu ";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {
                          //  Usuario.Id = reader.GetString(0);
                            Usuario.Nome = reader.GetString(1);
                            Usuario.cpf_cnpj = reader.GetString(2);
                            Usuario.rg = reader.GetString(3);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool SelecionarTransacao(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(id_usuario) Transacoes FROM transacao where id_usuario = @id_usu";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {                           
                            Transacao.TotalTransacao = reader.GetInt32(0);
                            
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

            
        }

        public bool SelecionarRealBit(int id)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "declare @bit float set @bit = (SELECT SUM (qtn_moeda*cotacao_moeda) AS Saldo_BitCoin FROM transacao t  WHERE id_usuario = @id_usu and  id_moedas = 1) SELECT @bit AS Saldo_BitCoin FROM transacao t  WHERE id_usuario = @id_usu and  id_moedas = 1 and @bit IS NOT NULL";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {

                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {
                            Transacao.TotalRealBit = reader.GetDouble(0);

                        }
                        return true;
                    }
                    else {

                        Transacao.TotalRealBit = 0;
                        return false;
                    }

                
                }
            }
        }
        
        public bool SelecionarRealEt(int id)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "declare @bit float set @bit = (SELECT SUM (qtn_moeda*cotacao_moeda) AS Saldo_BitCoin FROM transacao t  WHERE id_usuario = @id_usu and  id_moedas = 2) SELECT @bit AS Saldo_BitCoin FROM transacao t  WHERE id_usuario = @id_usu and  id_moedas = 2 and @bit IS NOT NULL ";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {

                            Transacao.TotalRealEt = reader.GetDouble(0);

                        }
                        return true;
                    }
                    else
                    {

                        Transacao.TotalRealEt = 0;
                        return false;
                    }
                }
            }
        }
        
        public bool SelecionarEthereum(int id)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select t.qtn_moeda from usuarios u inner join transacao t on u.id_usuario=t.id_usuario where u.id_usuario = @id_usu and t.id_moedas=2";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {

                            Transacao.TotalEthereum = reader.GetInt32(0);

                        }
                        return true;
                    }
                    else
                    {

                        Transacao.TotalEthereum = 0;
                        return false;
                    }
                }
            }
        }public bool SelecionarBitcoin(int id)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select t.qtn_moeda from usuarios u inner join transacao t on u.id_usuario=t.id_usuario where u.id_usuario = @id_usu and t.id_moedas=1";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {

                            Transacao.TotalBitcoin = reader.GetInt32(0);

                        }
                        return true;
                    }
                    else
                    {

                        Transacao.TotalBitcoin = 0;
                        return false;
                    }
                }
            }
        }
        public bool SelecionarLitecoin(int id)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select t.qtn_moeda from usuarios u inner join transacao t on u.id_usuario=t.id_usuario where u.id_usuario = @id_usu and t.id_moedas=3";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {

                            Transacao.TotalLiteCoin = reader.GetInt32(0);

                        }
                        return true;
                    }
                    else
                    {

                        Transacao.TotalLiteCoin = 0;
                        return false;
                    }
                }
            }
        }
        
        public bool SelecionarRealLite(int id)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "declare @bit float set @bit = (SELECT SUM (qtn_moeda*cotacao_moeda) AS Saldo_BitCoin FROM transacao t  WHERE id_usuario = @id_usu and  id_moedas = 3) SELECT @bit AS Saldo_BitCoin FROM transacao t  WHERE id_usuario = @id_usu and  id_moedas = 3 and @bit IS NOT NULL";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {

                            Transacao.TotalRealLite = reader.GetDouble(0);

                        }
                        return true;
                    }
                    else
                    {

                        Transacao.TotalRealLite = 0;
                        return false;
                    }
                }
            }
        }

        public DataSet Pesquisa(string id)
        {
            DataSet dt = new DataSet();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "select u.id_usuario as ID, u.nome as NOME, u.cpf_cnpj as CPF_CNPJ, u.rg as RG from usuarios u inner join cliente c on u.id_usuario=c.id_usuario where nome LIKE @id_usu OR cpf_cnpj LIKE @id_usu OR rg Like @id_usu";
                command.Parameters.AddWithValue("@id_usu","%" + id + "%");
                command.CommandType = CommandType.Text;
                    SqlDataAdapter adpt = new SqlDataAdapter(command);
                    adpt.Fill(dt);
                }

                return dt;
            }

        }   
        }
    }


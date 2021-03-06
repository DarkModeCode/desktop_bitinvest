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
    //OI ANY
    //Classe para buscar os dados no banco e verificar se o usuario existe
        public bool Login(string email, string senha)
        {
            var connection = GetConnection(); //chamando o metodo GetConnection da classe Banco
            connection.Open(); // abrindo a conexão
            var command = new SqlCommand();

            command.Connection = connection;
           // command.CommandText = "select * from usuarios where (email=@email and senha=@senha)"; //Selecionando os dados do usuario
            command.CommandText = "select u.nome,c.nome_cargo,p.id_perfil,u.id_usuario from usuarios u inner join usuario_tem_perfil up on up.id_usuario = u.id_usuario inner join perfil p on p.id_perfil=up.id_perfil full outer join funcionario f on f.id_usuario = u.id_usuario full outer join cargo c on c.id_cargo = f.id_cargo where (u.email=@email and u.senha=@senha)"; 

            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", senha);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())//Salva os dados em cache na classe Usuario
                {
                    Usuario.id_perfil = reader.GetInt32(2);

                    if (Usuario.id_perfil == 1)
                    {
                        Usuario.cargo = "Admin";

                    }
                    else {
                        Usuario.cargo = reader.GetString(1);

                    }
                    Usuario.NomeFun = reader.GetString(0);
                    Funcionario.Id = reader.GetInt32(3);

                }
                return true;
            }
            else
                return false;


        }
        //Codígo para confirmar o codigo quando o usuario esquece a senha
        public bool ConfirmarCod(int id_usuario, int cod)
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
        
        //Classe para verificar se o email do usuario existe para pedir a recuperação de senha
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
        //Classe para cadastrar clientes fisico
        public bool CadastrarClientes(string nome, string email, string senha, string data_nasc_fund, string sobrenome, string rg, string cpf_cnpj, string telefone_residencial,
        string celular, byte[] foto_doc_frente, byte[] foto_doc_tras, byte[] foto_doc_selfie, string renda_mensal, int tipo_pessoa, string rua, string bairro, string complemento, string cidade, string numero, string estado, string pais, string cep
            )
        {
        
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("inserir", connection);  //comando para inserir os dados na procedure de inserir dados na tabela usuario
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email ", email);
                    cmd.Parameters.AddWithValue("@senha ", senha);
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
                    SqlCommand cmmd = new SqlCommand("inserir_endereco", connection);  //comando para inserir os dados na procedure de inserir dados na tabela endereço
                    cmmd.CommandType = CommandType.StoredProcedure;
                    cmmd.Parameters.AddWithValue("@rua", rua);
                    cmmd.Parameters.AddWithValue("@bairro", bairro);
                    cmmd.Parameters.AddWithValue("@complemento", complemento);
                    cmmd.Parameters.AddWithValue("@cidade", cidade);
                    cmmd.Parameters.AddWithValue("@numero", numero);
                    cmmd.Parameters.AddWithValue("@estado", estado);
                    cmmd.Parameters.AddWithValue("@pais", pais);
                    cmmd.Parameters.AddWithValue("@cep", cep);
                    cmd.ExecuteNonQuery();   //executando o comando sql  
                    cmmd.ExecuteNonQuery();               
                }

                return true;
            }
        }  //Classe para cadastrar clientes juridico
        public bool CadastrarClientesJuridico(string nome, string email, string senha, string data_nasc_fund, string sobrenome, string rg, string cpf_cnpj, string telefone_residencial,
        string celular, int tipo_pessoa, string rua, string bairro, string complemento, string cidade, string numero, string estado, string pais, string cep
            )
        {
        
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("inserir_juridico", connection);  //comando para inserir os dados na procedure de inserir dados na tabela usuario
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email ", email);
                    cmd.Parameters.AddWithValue("@senha ", senha);
                    cmd.Parameters.AddWithValue("@sobrenome ", sobrenome);
                    cmd.Parameters.AddWithValue("@data_nasc_fund ", data_nasc_fund);
                    cmd.Parameters.AddWithValue("@rg ", rg);
                    cmd.Parameters.AddWithValue("@cpf_cnpj ", cpf_cnpj);
                    cmd.Parameters.AddWithValue("@telefone_residencial ", telefone_residencial);
                    cmd.Parameters.AddWithValue("@celular ", celular);
                    cmd.Parameters.AddWithValue("@tipo_pessoa ", tipo_pessoa);
                    SqlCommand cmmd = new SqlCommand("inserir_endereco", connection);  //comando para inserir os dados na procedure de inserir dados na tabela endereço
                    cmmd.CommandType = CommandType.StoredProcedure;
                    cmmd.Parameters.AddWithValue("@rua", rua);
                    cmmd.Parameters.AddWithValue("@bairro", bairro);
                    cmmd.Parameters.AddWithValue("@complemento", complemento);
                    cmmd.Parameters.AddWithValue("@cidade", cidade);
                    cmmd.Parameters.AddWithValue("@numero", numero);
                    cmmd.Parameters.AddWithValue("@estado", estado);
                    cmmd.Parameters.AddWithValue("@pais", pais);
                    cmmd.Parameters.AddWithValue("@cep", cep);
                    cmd.ExecuteNonQuery();   //executando o comando sql  
                    cmmd.ExecuteNonQuery();               
                }

                return true;
            }
        }
//Codigo para atualizar a senha do usuario
        public bool AtualizarSenha(int id_usuario, string senha)
        {
           
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("atualizar_senha", connection);   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario ", id_usuario);
                    cmd.Parameters.AddWithValue("@senha ", senha);
                    cmd.ExecuteNonQuery();                    
                }

                return true;
            }
        }
        
        //Codigo para atualizar os dados do cliente
        public bool AtualizarCliente(int id_usuario, string senha, string renda_mensal,string telefone_residencial,string sobrenome, string nome,string rg, string cpf_cnpj, string email, string celular, string data_nasc_fund)
        {
           
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("atualizar_cliente", connection);   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario ", id_usuario);
                    cmd.Parameters.AddWithValue("@renda_mensal ", renda_mensal);
                    cmd.Parameters.AddWithValue("@telefone_residencial ", telefone_residencial);
                    cmd.Parameters.AddWithValue("@nome ", nome);
                    cmd.Parameters.AddWithValue("@sobrenome ", sobrenome);
                    cmd.Parameters.AddWithValue("@rg ", rg);
                    cmd.Parameters.AddWithValue("@cpf_cnpj ", cpf_cnpj);
                    cmd.Parameters.AddWithValue("@email ", email);
                    cmd.Parameters.AddWithValue("@celular ", celular);
                    cmd.Parameters.AddWithValue("@data_nasc_fund ", data_nasc_fund);
                    cmd.Parameters.AddWithValue("@senha ", senha);
                    cmd.ExecuteNonQuery();                    
                }

                return true;
            }
        }public bool AtualizarFuncionario(int id_usuario,string telefone_residencial, string email, string celular)
        {
          
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("atualizar_funcionario", connection);   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario ", id_usuario);
                    cmd.Parameters.AddWithValue("@telefone_residencial ", telefone_residencial);
                    cmd.Parameters.AddWithValue("@email ", email);
                    cmd.Parameters.AddWithValue("@celular ", celular);
                 
                    cmd.ExecuteNonQuery();                    
                }

                return true;
            }
        }
        
        //Codigo para deletar os dados do cliente
        public bool DeletarCliente(int id_usuario, string obs)
        {
           using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("excluir_conta", connection);   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario ", id_usuario);
                    cmd.Parameters.AddWithValue("@obs ", obs);
                    cmd.ExecuteNonQuery();                    
                }

                return true;
            }
        }
       
        
//Classe para inserir o código do esqueci a senha do usuario na tabela esqueci a senha
        public bool Esqueceu(int id_usuario, int cod)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("esqueci", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.Parameters.AddWithValue("@codigo", cod);
                    cmd.ExecuteNonQuery();                     
                }

                return true;

            }
        }
        //Codigo para selecionar os clientes cadastrados
        public DataTable SelecionarClientes()
        {
            using (var con = GetConnection())
            {
                DataTable dt = new DataTable();
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select u.id_usuario as ID, u.nome as NOME, u.cpf_cnpj as CPF_CNPJ, u.rg as RG from usuarios u inner join Cliente c on c.Id_usuario=u.id_usuario;", con))
                {

                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    adpt.Fill(dt);
                }

                return dt;
            }
        }   
        //Codigo para selecionar os clientes pendentes
        public DataSet SelecionarClientesPendentes()
        {
            using (var con = GetConnection())
            {
                con.Open();
                string query = "select data_nasc_fund, nome,cpf_cnpj ,rg from analise;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet dtset = new DataSet();
                adapter.Fill(dtset);
                return dtset;
            }
        }
//classe para pegar o valor da linha selecionada pelo cliente
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
//Classe para selecionar as transações do usuario
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
//Classe para selecionar o valor em Real do Bitcoin do usuario
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
                    else
                    {

                        Transacao.TotalRealBit = 0;
                        return false;
                    }


                }
            }
        }
//Classe para selecionar o valor em Real do Ethereum  do usuario

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
        //Classe para selecionar o valor do Ethereum do usuario

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
        }public bool SelecionarFuncionario(int id)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from usuarios u inner join funcionario f on u.id_usuario=f.id_usuario inner join cargo c on c.id_cargo=f.id_cargo where u.id_usuario = @id_usu";
                    command.Parameters.AddWithValue("@id_usu", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtemos os dados das colunas e salvamos no cache do Usuario
                        {


                            Funcionario.Id = reader.GetInt32(8);
                            Funcionario.Nome = reader.GetString(3);
                            Funcionario.Sobrenome = reader.GetString(5); 
                            Funcionario.Data_nasc = reader.GetString(0); 
                            Funcionario.cpf = reader.GetString(7); 
                            Funcionario.rg = reader.GetString(6); 
                            Funcionario.CargoNome = reader.GetString(23); 
                            Funcionario.celular = reader.GetString(10); 
                            Funcionario.telefone_residencial = reader.GetString(9); 
                            Funcionario.Email = reader.GetString(2); 
                            Funcionario.Senha = reader.GetString(1); 

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
        }
        //Classe para selecionar o valor do Bitcoin do usuario

        public bool SelecionarBitcoin(int id)
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
        //Classe para selecionar o valor do LiteCoin do usuario

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
//Classe para selecionar o valor em Real do Litecoin do usuario

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
//Classe para fazer a pesquisa dinamica do cliente
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
                    command.Parameters.AddWithValue("@id_usu", "%" + id + "%");
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adpt = new SqlDataAdapter(command);
                    adpt.Fill(dt);
                }

                return dt;
            }

        }

//Classe para cadastrar o funcionario
        public bool CadastrarFuncionario(string nome, string email, string senha, string data_nasc_fund, string sobrenome, string rg, string cpf_cnpj, string telefone_residencial,
            string celular, string CTPS, string data_de_demissao, string salario, string horario_de_trabalho, string concessao_de_ferias,
string pis_paes, string obs, string data_de_admissao, string tipo_contrato, string dias_de_trabalho,
int id_cargo, int id_perfil, string rua, string bairro, string complemento, string cidade, string numero, string estado, string pais, string cep, string n_conta_bancaria, string n_agencia, int cod_banco
                )
        {
           
           
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("Cadastro_funcionario", connection);  //creating  SqlCommand  object  
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email ", email);
                    cmd.Parameters.AddWithValue("@senha ", senha);
                    cmd.Parameters.AddWithValue("@sobrenome ", sobrenome);
                    cmd.Parameters.AddWithValue("@data_nasc_fund ", data_nasc_fund);
                    cmd.Parameters.AddWithValue("@rg ", rg);
                    cmd.Parameters.AddWithValue("@cpf_cnpj ", cpf_cnpj);
                    cmd.Parameters.AddWithValue("@telefone_residencial ", telefone_residencial);
                    cmd.Parameters.AddWithValue("@celular ", celular);
                    cmd.Parameters.AddWithValue("@CTPS ", CTPS);
                    cmd.Parameters.AddWithValue("@data_de_demissao", data_de_demissao);
                    cmd.Parameters.AddWithValue("@salario", salario);
                    cmd.Parameters.AddWithValue("@horario_de_trabalho", horario_de_trabalho);
                    cmd.Parameters.AddWithValue("@concessao_de_ferias", concessao_de_ferias);
                    cmd.Parameters.AddWithValue("@pis_paes", pis_paes);
                    cmd.Parameters.AddWithValue("@data_de_admissao", data_de_admissao);
                    cmd.Parameters.AddWithValue("@tipo_contrato", tipo_contrato);
                    cmd.Parameters.AddWithValue("@dias_de_trabalho", dias_de_trabalho);
                    cmd.Parameters.AddWithValue("@id_cargo ", id_cargo);
                    cmd.Parameters.AddWithValue("@id_perfil ", id_perfil);
                    cmd.Parameters.AddWithValue("@obs", obs);
                    SqlCommand cmmd = new SqlCommand("inserir_endereco", connection);  //creating  SqlCommand  object  
                    cmmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();                     //executing the sqlcommand  
                    cmmd.Parameters.AddWithValue("@rua", rua);
                    cmmd.Parameters.AddWithValue("@bairro", bairro);
                    cmmd.Parameters.AddWithValue("@complemento", complemento);
                    cmmd.Parameters.AddWithValue("@cidade", cidade);
                    cmmd.Parameters.AddWithValue("@numero", numero);
                    cmmd.Parameters.AddWithValue("@estado", estado);
                    cmmd.Parameters.AddWithValue("@pais", pais);
                    cmmd.Parameters.AddWithValue("@cep", cep);
                    SqlCommand commd = new SqlCommand("inserir_dados_bancarios", connection);  //creating  SqlCommand  object  
                    commd.CommandType = CommandType.StoredProcedure;
                    commd.Parameters.AddWithValue("@n_conta_bancaria", n_conta_bancaria);
                    commd.Parameters.AddWithValue("@n_agencia", n_agencia);
                    commd.Parameters.AddWithValue("@cod_banco", cod_banco);
                    commd.ExecuteNonQuery();                     //executing the sqlcommand  
                    cmmd.ExecuteNonQuery();                     //executing the sqlcommand  



                }

                return true;
            }
        }
    }

}

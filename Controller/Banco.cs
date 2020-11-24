using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_bitinvest_v1.Controller
{
//classe de conexão com o banco de dados sqlserver
    public abstract class Banco
    {
    
        private readonly string connectionString;
        public Banco()
        {
            connectionString = "Data Source=bit-invest.database.windows.net;Initial Catalog=bit_invest;Persist Security Info=True;User ID=bit;Password=070220DMCBI."; //string de conexao
        }
        
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

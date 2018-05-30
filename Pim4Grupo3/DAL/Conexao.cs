using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim4Grupo3.DAL
{
    public class Conexao
    {
        SqlConnection connection;

        public Conexao()
        {
            connection = new SqlConnection();
            connection.ConnectionString =
            @"Data Source=DESKTOP-POSJCLT\SQLEXPRESS;
            Initial Catalog=pimfinal;
            User ID=sa;Password=unip";

        }

        public SqlConnection Conectar()
        {
            if (connection.State ==
                System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void Desconectar()
        {
            if (connection.State ==
                System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

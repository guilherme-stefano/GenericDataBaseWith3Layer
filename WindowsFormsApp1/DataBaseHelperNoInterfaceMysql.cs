using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class DataBaseHelperNoInterfaceMysql
    {
        public DataBaseHelperNoInterfaceMysql()
        {
            var connString = "Server=localhost;Database=teste;Uid=root;Pwd=root";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO pessoa (name) VALUES ('mario')";
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}

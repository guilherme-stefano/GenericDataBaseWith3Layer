using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class DataBaseHelperMysql : AbstractDataBaseHelper
    {

        public DataBaseHelperMysql (string connectionString) : base(connectionString)
        {

        }

        public override IDbCommand getCommand()
        {
            return this.connection.CreateCommand();
        }

        public override IDbConnection getConnection(string connection)
        {
            return new MySqlConnection(connection);
        }
    }
}

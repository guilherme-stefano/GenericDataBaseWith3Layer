using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataBaseHelperSqlServer: AbstractDataBaseHelper
    {

        public DataBaseHelperSqlServer(string connectionString) : base(connectionString)
        {
            
        }

        public override IDbCommand getCommand()
        {
            return this.connection.CreateCommand();
        }

        public override IDbConnection getConnection(string connection)
        {
            return new SqlConnection(connection);
        }
    }
}

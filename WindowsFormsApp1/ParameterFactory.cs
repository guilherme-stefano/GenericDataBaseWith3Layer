using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace DAL
{
    public class ParameterFactory
    {
        private string v;
        private int iD;

        public static IDbDataParameter generateParameter(Type.Base type)
        {
            if (type == Type.Base.MySql)
                return new MySqlParameter();
            else
                return new SqlParameter();
        }

    }
}

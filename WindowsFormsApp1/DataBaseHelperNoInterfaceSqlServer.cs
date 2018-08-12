using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataBaseHelperNoInterfaceSqlServer
    {
        public DataBaseHelperNoInterfaceSqlServer()
        {
            SqlConnection conection = new SqlConnection("Server=DESKTOP-5LSHH6H; Database= testechulo; Integrated Security=SSPI; Uid=auth_windows;");
            conection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update pessoa set name='maria' where id = 1";
            cmd.Connection = conection;
            cmd.ExecuteNonQuery();
        }
    }
}

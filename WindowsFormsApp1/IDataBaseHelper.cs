using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    public interface IDataBaseHelper 
    {
         IDbConnection getConnection(string connection);
         IDbCommand getCommand();
    }
}

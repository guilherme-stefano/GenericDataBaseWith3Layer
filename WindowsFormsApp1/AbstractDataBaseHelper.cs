using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class AbstractDataBaseHelper : IDataBaseHelper
    {
        protected string connectionString;
        protected IDbConnection connection;
        public AbstractDataBaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
            this.connection = this.getConnection(connectionString);
        }

        public void openConnection()
        {
            this.connection.Open();
        }

        public void closeConnection()
        {
            this.connection.Close();
        }

        public void executeQuery(string query, IDbDataParameter[] parameters)
        {
            var command = this.getCommand();
            command.CommandText = query;
            foreach (IDbDataParameter parameter in parameters) {
                command.Parameters.Add(parameter);
            }
            command.ExecuteNonQuery();
            
        }

        public IDataReader executeReader(string query, IDbDataParameter[] parameters)
        {
            var command = this.getCommand();
            command.CommandText = query;
            foreach (IDbDataParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
            IDataReader reader = command.ExecuteReader();
            command.Parameters.Clear();
            return reader;
        }

        public IDataReader executeReader(string query)
        {
            var command = this.getCommand();
            command.CommandText = query;
            IDataReader reader = command.ExecuteReader();
            return reader;
        }

        public abstract IDbCommand getCommand();
        public abstract IDbConnection getConnection(string connection);
    }
}

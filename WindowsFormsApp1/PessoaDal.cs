using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class PessoaDAL : DataAccessObject<Pessoa>
    {
        public AbstractDataBaseHelper database;

        public Type.Base type;

        public PessoaDAL(Type.Base type)
        {
            this.type =  type;
            if (type == Type.Base.MySql)
                this.database = new DataBaseHelperMysql("Server=localhost;Database=teste;Uid=root;Pwd=root");
            else
                this.database = new DataBaseHelperSqlServer("Server=DESKTOP-5LSHH6H; Database= testechulo; Integrated Security=SSPI; Uid=auth_windows;");
        }

        public void delete(Pessoa o)
        {
            this.database.openConnection();
            string sqlQuery = "delete from pessoa where id = @id" ;
            var parameter =  ParameterFactory.generateParameter(this.type);
            parameter.ParameterName = "id";
            parameter.Value = o.ID;
            IDbDataParameter[] parameters = new IDbDataParameter[1];
            parameters[0] = parameter;
            this.database.executeQuery(sqlQuery, parameters);
            this.database.closeConnection();
        }

        public Pessoa get(int id)
        {
            this.database.openConnection();
            string querySelect = "select * from pessoa where id = @id";
            var parameter = ParameterFactory.generateParameter(this.type);
            parameter.ParameterName = "id";
            parameter.Value = id;
            IDbDataParameter[] parameters = new IDbDataParameter[1];
            parameters[0] = parameter;
            var reader = this.database.executeReader(querySelect, parameters);
            Pessoa pessoa = new Pessoa();
            while (reader.Read())
            {
                pessoa.ID = id;
                pessoa.Name = reader["name"].ToString();
            }
            this.database.closeConnection();
            return pessoa;
           
        }

        public List<Pessoa> getAll()
        {
            this.database.openConnection();
            string querySelect = "select * from pessoa";
            var reader = this.database.executeReader(querySelect);
            List<Pessoa> pessoaList = new List<Pessoa>();
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.ID = Convert.ToInt32(reader["id"].ToString());
                pessoa.Name = reader["name"].ToString();
                pessoaList.Add(pessoa);
            }
            this.database.closeConnection();
            return pessoaList;
        }

        public void insert(Pessoa o)
        {
            this.database.openConnection();
            string query = "insert into pessoa (name) values (@name)";
            var parameter = ParameterFactory.generateParameter(this.type);
            parameter.ParameterName = "name";
            parameter.Value = o.Name;
            IDbDataParameter[] parameters = new IDbDataParameter[1];
            parameters[0] = parameter;
            this.database.executeQuery(query, parameters);
            this.database.closeConnection();
        }

        public void update(Pessoa o)
        {
            this.database.openConnection();
            string query = "update pessoa set name = @name where id = @id";
            var parameter1 = ParameterFactory.generateParameter(this.type);
            parameter1.ParameterName = "id";
            parameter1.Value = o.ID;
            var parameter2 = ParameterFactory.generateParameter(this.type);
            parameter2.ParameterName = "name";
            parameter2.Value = o.Name;
            IDbDataParameter[] parameters = new IDbDataParameter[2];
            parameters[0] = parameter1;
            parameters[1] = parameter2;
            this.database.executeQuery(query, parameters);
            this.database.closeConnection();
        }
    }
}

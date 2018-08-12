using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace WindowsFormsApp1
{
    public class PessoaBLL : DataAccessObject<Pessoa>
    {
        public PessoaDAL pessoaDal;

        public PessoaBLL(DAL.Type.Base type)
        {
            this.pessoaDal = new PessoaDAL(type);
        }
        public void delete(Pessoa o)
        {
            this.pessoaDal.delete(o);
        }

        public Pessoa get(int id)
        {
            return this.pessoaDal.get(id);
        }

        public List<Pessoa> getAll()
        {
           return  this.pessoaDal.getAll();
        }

        public void insert(Pessoa o)
        {
            this.pessoaDal.insert(o);
        }

        public void update(Pessoa o)
        {
            this.pessoaDal.update(o);
        }
    }
}

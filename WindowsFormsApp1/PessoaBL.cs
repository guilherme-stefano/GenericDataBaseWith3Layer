using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DataAccess;
using Entity;

namespace BL
{

    public class PessoaBL : DataAccessObject<Pessoa>
    {
        public PessoaDal pessoaDal;

        public PessoaBL ()
        {
            this.pessoaDal = new PessoaDal();
        }

        public void delete(Pessoa o)
        {
            // caso tenha alguma alguma regra de negocio implementar aqui 
            this.pessoaDal.delete(o);
        }

        public Pessoa get(int id)
        {
            return this.pessoaDal.get(id);
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

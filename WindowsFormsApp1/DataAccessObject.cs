using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface DataAccessObject <T> where T : new()
    {
        T get(int id);
        void insert(T o);
        void update(T o);
        void delete(T o);
        List<T> getAll();
    }
}

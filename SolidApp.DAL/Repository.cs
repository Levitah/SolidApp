using SolidApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.DAL
{
    public class Repository<T> : IRepository<T>
    {
        public IEnumerable<T> ListAll()
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(T item)
        {
            //TODO: Implement Save method
            throw new NotImplementedException();
        }
    }
}
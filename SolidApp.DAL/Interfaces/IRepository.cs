using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.DAL.Interfaces
{
    public interface IRepository<T>
    {
        void Save(T item);
        IEnumerable<T> ListAll();
        T FindById(string id);

        void DeleteById(string id);
    }
}
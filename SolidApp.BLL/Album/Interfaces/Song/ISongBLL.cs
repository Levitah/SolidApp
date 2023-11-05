using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.BLL.Album.Interfaces
{
    public interface ISongBLL
    {
        void Save(Entity.Song song);
        IEnumerable<Entity.Song> ListAll();
        Entity.Song FindById(string id);
        void DeleteById(string id);
    }
}
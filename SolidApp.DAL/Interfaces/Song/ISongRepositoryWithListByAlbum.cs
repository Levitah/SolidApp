using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.DAL.Interfaces.Song
{
    public interface ISongRepositoryWithListByAlbum<T> : IRepository<T>
    {
        IEnumerable<T> ListByAlbum(string albumId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.BLL.Album.Interfaces
{
    public interface ISongWithListByAlbumBLL : ISongBLL
    {
        IEnumerable<Entity.Song> ListByAlbum(string albumId);
    }
}
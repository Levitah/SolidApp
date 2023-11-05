using SolidApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.BLL.Song
{
    internal class SongWithListByAlbumBLL : SongBLL
    {
        DAL.Interfaces.Song.ISongRepositoryWithListByAlbum<Entity.Song> songRepository;

        public SongWithListByAlbumBLL(DAL.Interfaces.Song.ISongRepositoryWithListByAlbum<Entity.Song> songRepository) : base(songRepository)
        {
        }
    }
}
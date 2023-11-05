using SolidApp.BLL.Album;
using SolidApp.BLL.Album.Interfaces;
using SolidApp.BLL.Song;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.BLL
{
    public class Services
    {
        public IAlbumBLL albumBLL { get; private set; }
        public ISongWithListByAlbumBLL songBLL { get; private set; }
        public Services()
        {
            this.albumBLL = new AlbumBLL(
                new DAL.Album.AlbumDAL()
            );
            this.songBLL = new SongWithListByAlbumBLL(
                new DAL.Song.SongDAL()
            );
        }
    }
}
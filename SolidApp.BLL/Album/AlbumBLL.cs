using SolidApp.BLL.Album.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.BLL.Album
{
    internal class AlbumBLL : IAlbumBLL
    {
        DAL.Interfaces.IRepository<Entity.Album> albumRepository;

        public AlbumBLL(DAL.Interfaces.IRepository<Entity.Album> albumRepository)
        {
            this.albumRepository = albumRepository;
        }

        public Entity.Album FindById(int id)
        {
            return albumRepository.FindById(id);
        }

        public IEnumerable<Entity.Album> ListAll()
        {
            return albumRepository.ListAll();
        }

        public void Save(Entity.Album album)
        {
            albumRepository.Save(album);
        }
    }
}
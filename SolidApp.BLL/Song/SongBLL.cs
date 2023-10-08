using SolidApp.BLL.Album.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.BLL.Song
{
    internal class SongBLL : ISongBLL
    {
        DAL.Interfaces.IRepository<Entity.Song> songRepository;

        public SongBLL(DAL.Interfaces.IRepository<Entity.Song> songRepository)
        {
            this.songRepository = songRepository;
        }

        public void DeleteById(string id)
        {
            this.songRepository.DeleteById(id);
        }

        public Entity.Song FindById(string id)
        {
            return songRepository.FindById(id);
        }

        public IEnumerable<Entity.Song> ListAll()
        {
            return songRepository.ListAll();
        }

        public void Save(Entity.Song song)
        {
            songRepository.Save(song);
        }
    }
}

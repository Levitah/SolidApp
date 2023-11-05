using MongoDB.Driver;
using SolidApp.DAL.Base;
using SolidApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.DAL.Song
{
    public class SongDAL : MongoRepository<Entity.Song>, Interfaces.Song.ISongRepositoryWithListByAlbum<Entity.Song>
    {
        public SongDAL() : base(ConfigurationManager.AppSettings["Database.TableName.Song"])
        {
        }

        public IEnumerable<Entity.Song> ListByAlbum(string albumId)
        {
            return GetCollection().Find(Builders<Entity.Song>.Filter.Where(x => x.AlbumId == albumId)).ToList();
        }
    }
}
using SolidApp.DAL.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.DAL.Album
{
    public class AlbumDAL : MongoRepository<Entity.Album>
    {
        public AlbumDAL() : base(ConfigurationManager.AppSettings["Database.TableName.Album"])
        {
        }
    }
}
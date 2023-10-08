using SolidApp.DAL.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.DAL.Song
{
    public class SongDAL : MongoRepository<Entity.Song>
    {
        public SongDAL() : base(ConfigurationManager.AppSettings["Database.TableName.Song"])
        {
        }
    }
}

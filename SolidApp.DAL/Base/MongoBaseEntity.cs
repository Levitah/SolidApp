using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.DAL.Base
{
    public class MongoBaseEntity
    {
        private MongoDB.Bson.ObjectId _id;
        public string Id { get { return _id.ToString(); } set { _id = MongoDB.Bson.ObjectId.Parse(value); } }
    }
}
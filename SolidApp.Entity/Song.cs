using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.Entity
{
    public class Song : Entity.Base.IBaseEntity
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Order { get; private set; }
        public string AlbumId { get; private set; }

        public Song(string name, int order, string albumId) : this(Guid.NewGuid().ToString(), name, order, albumId)
        {
        }

        public Song(string id, string name, int order, string albumId)
        {
            Id = id;
            Name = name;
            Order = order;
            AlbumId = albumId;
        }
    }
}
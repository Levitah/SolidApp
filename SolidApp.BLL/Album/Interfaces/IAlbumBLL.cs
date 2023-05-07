using System;
using System.Collections.Generic;

namespace SolidApp.BLL.Album.Interfaces
{
    public interface IAlbumBLL
    {
        void Save(Entity.Album album);
        IEnumerable<Entity.Album> ListAll();
        Entity.Album FindById(string id);
    }
}
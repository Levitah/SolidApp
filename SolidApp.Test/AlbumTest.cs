using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidApp.BLL;
using SolidApp.BLL.Album;
using SolidApp.Entity;
using System;

namespace SolidApp.Test
{
    [TestClass]
    public class AlbumTest
    {
        private Services services = new Services();

        [TestMethod]
        public void InsertAlbum()
        {
            Album album = new Album("This is Why", "Paramore", "Alternative Rock", 2023);
            services.albumBLL.Save(album);
        }
    }
}
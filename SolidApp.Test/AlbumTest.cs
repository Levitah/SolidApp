using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidApp.BLL;
using SolidApp.BLL.Album;
using SolidApp.Entity;
using System;
using System.Linq;

namespace SolidApp.Test
{
    [TestClass]
    public class AlbumTest
    {
        private Services services = new Services();

        [TestMethod]
        public void SaveAlbum()
        {
            Album album = new Album("This is Why", "Paramore", "Alternative Rock", 2023);
            services.albumBLL.Save(album);

            string itemId = album.Id;

            Album savedAlbum = services.albumBLL.FindById(itemId);

            CompareObjects(album, savedAlbum);

            album = new Album(itemId, "Batavi", "Heidevolk", "Pagan Metal", 2012);
            services.albumBLL.Save(album);

            savedAlbum = services.albumBLL.FindById(itemId);

            CompareObjects(album, savedAlbum);

            services.albumBLL.DeleteById(album.Id);
        }

        [TestMethod]
        public void FindAlbum()
        {
            int countBeforeSave = services.albumBLL.ListAll().Count();

            Album album = new Album("La Drácula", "Jotta A", "Pop", 2023);
            services.albumBLL.Save(album);

            int countAfterSave = services.albumBLL.ListAll().Count();

            services.albumBLL.DeleteById(album.Id);

            Assert.AreEqual(countBeforeSave + 1, countAfterSave);
        }

        private void CompareObjects(Album album, Album savedAlbum)
        {
            Assert.AreEqual(album.Id, savedAlbum.Id);
            Assert.AreEqual(album.Name, savedAlbum.Name);
            Assert.AreEqual(album.Artist, savedAlbum.Artist);
            Assert.AreEqual(album.Genre, savedAlbum.Genre);
            Assert.AreEqual(album.Year, savedAlbum.Year);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidApp.BLL;
using SolidApp.Entity;
using System;
using System.Linq;

namespace SolidApp.Test
{
    [TestClass]
    public class SongTest
    {
        private Services services = new Services();

        [TestMethod]
        public void SaveSong()
        {
            Song song = new Song("Wut", 1, Guid.NewGuid().ToString());
            services.songBLL.Save(song);

            string itemId = song.Id;

            Song savedSong = services.songBLL.FindById(itemId);

            CompareObjects(song, savedSong);

            song = new Song(itemId, "Ecce Homo", 5, Guid.NewGuid().ToString());
            services.songBLL.Save(song);

            savedSong = services.songBLL.FindById(itemId);

            CompareObjects(song, savedSong);

            services.songBLL.DeleteById(song.Id);
        }

        [TestMethod]
        public void FindSong()
        {
            int countBeforeSave = services.songBLL.ListAll().Count();

            Song song = new Song("Humano", 2, Guid.NewGuid().ToString());
            services.songBLL.Save(song);

            int countAfterSave = services.songBLL.ListAll().Count();

            services.songBLL.DeleteById(song.Id);

            Assert.AreEqual(countBeforeSave + 1, countAfterSave);
        }

        private void CompareObjects(Song song, Song savedSong)
        {
            Assert.AreEqual(song.Id, savedSong.Id);
            Assert.AreEqual(song.Name, savedSong.Name);
            Assert.AreEqual(song.Order, savedSong.Order);
            Assert.AreEqual(song.AlbumId, savedSong.AlbumId);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidApp.BLL;
using SolidApp.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SolidApp.Test
{
    [TestClass]
    public class SongTest
    {
        private Services services = new Services();

        //[TestMethod]
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

        //[TestMethod]
        public void FindSong()
        {
            int countBeforeSave = services.songBLL.ListAll().Count();

            Song song = new Song("Humano", 2, Guid.NewGuid().ToString());
            services.songBLL.Save(song);

            int countAfterSave = services.songBLL.ListAll().Count();

            services.songBLL.DeleteById(song.Id);

            Assert.AreEqual(countBeforeSave + 1, countAfterSave);
        }

        //[TestMethod]
        public void ListSongByAlbum()
        {
            string albumId = Guid.NewGuid().ToString();
            string otherAlbumId = Guid.NewGuid().ToString();

            Song songOne = new Song("Wiseman", 1, albumId);
            Song songTwo = new Song("Alley Cat", 2, albumId);
            Song songThree = new Song("Carry On", 2, otherAlbumId);

            services.songBLL.Save(songOne);
            services.songBLL.Save(songTwo);
            services.songBLL.Save(songThree);

            services.songBLL.ListAll();
            IEnumerable<Song> songList = services.songBLL.ListByAlbum(albumId);
            int albumQtd = songList.Count();

            services.songBLL.DeleteById(songOne.Id);
            services.songBLL.DeleteById(songTwo.Id);
            services.songBLL.DeleteById(songThree.Id);

            Assert.AreEqual(2, albumQtd);
            Assert.IsTrue(songList.Any(x => x.Id.Equals(songOne.Id)));
            Assert.IsTrue(songList.Any(x => x.Id.Equals(songTwo.Id)));
            Assert.IsFalse(songList.Any(x => x.Id.Equals(songThree.Id)));
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
using SolidApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.Entity
{
    public class Album : IBaseEntity
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Artist { get; private set; }
        public string Genre { get; private set; }
        public int Year { get; private set; }

        public Album(string name, string artist, string genre, int year)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Artist = artist;
            Genre = genre;
            Year = year;
        }
    }
}
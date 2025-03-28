﻿using SolidApp.BLL;
using SolidApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services services = new Services();  

            IEnumerable<Album> albums = services.albumBLL.ListAll();

            Album album = new Album("Tell me I'm Alive", "All Time Low", "Pop Punk", 2023);
            services.albumBLL.Save(album);
        }
    }
}
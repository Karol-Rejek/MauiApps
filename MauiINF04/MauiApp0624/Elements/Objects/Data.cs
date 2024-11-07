using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp0624.Elements.Objects
{
    internal class Data
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string SongsNumber { get; set; }
        public int Year { get; set; }
        public int DownloadNumber { get; set; }

        private Data(string artist, string album, string songsNumber, int year, int downloadNumber)
        {
            this.Artist = artist;
            this.Album = album;
            this.SongsNumber = songsNumber;
            this.Year = year;
            this.DownloadNumber = downloadNumber;
        }
    }
}

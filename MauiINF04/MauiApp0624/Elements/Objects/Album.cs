using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp0624.Elements.Objects
{
    internal class Album
    {
        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public int SongsNumber { get; set; }
        public int Year { get; set; }
        public int DownloadNumber { get; set; }

        public Album() { }

        public Album(string artist, string album, int songsNumber, int year, int downloadNumber)
        {
            this.Artist = artist;
            this.AlbumName = album;
            this.SongsNumber = songsNumber;
            this.Year = year;
            this.DownloadNumber = downloadNumber;
        }
    }
}

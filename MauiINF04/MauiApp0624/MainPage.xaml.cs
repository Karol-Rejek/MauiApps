using MauiApp0624.Elements.Objects;

namespace MauiApp0624
{
    public partial class MainPage : ContentPage
    {
        private List<Album> albums;
        public int currentAlbumIndex = 0;

        public MainPage()
        {
            InitializeComponent();

            this.albums = new List<Album>();

            ReadFromFile("Data.txt");

            //string filepath = Path.Combine(AppContext.BaseDirectory, "Data.txt");
            //using (StreamReader reader = new(filepath)) 
            //{
            //    string line, newline;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Data newData = new Data()
            //        { 
            //            Artist = line,
            //            Album = reader.ReadLine(),
            //            SongsNumber = int.Parse(reader.ReadLine()),
            //            Year = int.Parse(reader.ReadLine()),
            //            DownloadNumber = int.Parse(reader.ReadLine()),
            //        };
            //        newline = reader.ReadLine();
            //        datas.Add(newData);
            //    }
            //}
            UpdateCurrentData();
        }

        private void ReadFromFile(string file) // READ FROM FILE AND SAVE DATA IN COLECTION
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, file);
            using (StreamReader reader = new(filePath))
            {
                string lineArtist;
                while ((lineArtist = reader.ReadLine()) != null)
                {
                    Album newData = new Album()
                    {
                        Artist = lineArtist,
                        AlbumName = reader.ReadLine(),
                        SongsNumber = int.Parse(reader.ReadLine()),
                        Year = int.Parse(reader.ReadLine()),
                        DownloadNumber = int.Parse(reader.ReadLine()),
                    };
                    reader.ReadLine();
                    albums.Add(newData);
                }
            }
        }

        private void UpdateCurrentData() // UPDATE CURRENT SHOWED DATA ELEMENT
        {
            artistLabel.Text = albums[currentAlbumIndex].Artist;
            albumLabel.Text = albums[currentAlbumIndex].AlbumName;
            songsNumberLabel.Text = albums[currentAlbumIndex].SongsNumber.ToString() + " utworów";
            yearLabel.Text = albums[currentAlbumIndex].Year.ToString();
            downloadsLabel.Text = albums[currentAlbumIndex].DownloadNumber.ToString();
        }

        private void Button_Clicked_Back(object sender, EventArgs e) // GO TO PREVIOUS ELEMENT
        {
            currentAlbumIndex = (currentAlbumIndex + 1) % albums.Count;
            UpdateCurrentData();
        }

        private void Button_Clicked_Next(object sender, EventArgs e) // GO TO NEXT ELEMENT
        {
            currentAlbumIndex = (currentAlbumIndex - 1 + albums.Count) % albums.Count;
            UpdateCurrentData();
        }

        private void Button_Clicked_Download(object sender, EventArgs e) // INCREASED DOWNLOADS NUMBER
        {
            albums[currentAlbumIndex].DownloadNumber++;
            UpdateCurrentData();
        }
    }

}

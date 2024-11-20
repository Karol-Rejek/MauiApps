using MauiApp0624.Elements.Objects;

namespace MauiApp0624
{
    public partial class MainPage : ContentPage
    {
        private List<Data> datas;
        public int currentIndex = 0;

        public MainPage()
        {
            InitializeComponent();

            this.datas = new List<Data>();

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
                string line, emptyLine;
                while ((line = reader.ReadLine()) != null)
                {
                    Data newData = new Data(line, reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()));
                    emptyLine = reader.ReadLine();
                    datas.Add(newData);
                }
            }
        }

        private void UpdateCurrentData() // UPDATE CURRENT SHOWED DATA ELEMENT
        {
            artistLabel.Text = datas[currentIndex].Artist;
            albumLabel.Text = datas[currentIndex].Album;
            songsNumberLabel.Text = datas[currentIndex].SongsNumber.ToString() + " utworów";
            yearLabel.Text = datas[currentIndex].Year.ToString();
            downloadsLabel.Text = datas[currentIndex].DownloadNumber.ToString();
        }

        private void Button_Clicked_Back(object sender, EventArgs e) // GO TO PREVIOUS ELEMENT
        {
            currentIndex = (currentIndex + 1) % datas.Count;
            UpdateCurrentData();
        }

        private void Button_Clicked_Next(object sender, EventArgs e) // GO TO NEXT ELEMENT
        {
            currentIndex = (currentIndex - 1 + datas.Count) % datas.Count;
            UpdateCurrentData();
        }

        private void Button_Clicked_Download(object sender, EventArgs e) // INCREASED DOWNLOADS NUMBER
        {
            datas[currentIndex].DownloadNumber++;
            UpdateCurrentData();
        }
    }

}

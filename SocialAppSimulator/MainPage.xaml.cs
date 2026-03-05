using SocialAppSimulator.src.VievModels;

namespace SocialAppSimulator
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}

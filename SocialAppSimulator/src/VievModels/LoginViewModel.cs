using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SocialAppSimulator.src.VievModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;


        [RelayCommand]
        void Login()
        {
            Email = string.Empty;
            Password = string.Empty;
        }
    }
}

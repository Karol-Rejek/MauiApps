using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SocialAppSimulator.Views;

namespace SocialAppSimulator.src.VievModels
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoToLoginPage()
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        [RelayCommand]
        async Task GoToRegisterPage()
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }

    }
}

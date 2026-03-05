using SocialAppSimulator.src.VievModels;

namespace SocialAppSimulator.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}
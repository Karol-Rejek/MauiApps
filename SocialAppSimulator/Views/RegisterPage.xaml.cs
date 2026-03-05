using SocialAppSimulator.src.VievModels;

namespace SocialAppSimulator.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}
using VCShuttle_Login.Services;

namespace VCShuttle_Login.Pages;

public partial class ProfilePage : ContentPage
{
    private readonly AuthService _authService;

    public ProfilePage(AuthService authService)
    {
        InitializeComponent();
        _authService = authService;
    }

    private void Logout_Clicked(object sender, EventArgs e)
    {
        _authService.Logout();
        Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}
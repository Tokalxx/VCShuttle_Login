using VCShuttle_Login.Services;

namespace VCShuttle_Login.Pages;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;
    public LoginPage(AuthService authService)
    {
        InitializeComponent();
        _authService = authService;
    }

    public AuthService AuthService { get; }

    private async void Login_Click(object sender, EventArgs e)
    {
        _authService.Login();
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}
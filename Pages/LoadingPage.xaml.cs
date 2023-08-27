using VCShuttle_Login.Services;

namespace VCShuttle_Login.Pages;

public partial class LoadingPage : ContentPage
{
    private readonly AuthService _authService;
    public LoadingPage(AuthService authservice)
    {
        InitializeComponent();
        _authService = authservice;
    }

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (await _authService.IsAuthenticationAsync())
        {
            //User is logged in
            //redirted to main page
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            // User is not logged in
            // Redirect to LoginPage
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
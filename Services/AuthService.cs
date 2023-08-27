namespace VCShuttle_Login.Services
{
    public class AuthService
    {
        private const string AuthStateKey = "AythState";
        public async Task<bool> IsAuthenticationAsync()
        {
            await Task.Delay(2000);

            var authState = Preferences.Default.Get<bool>(AuthStateKey, false);


            return false;
        }

        public void Login()
        {
            Preferences.Default.Set<bool>(AuthStateKey, true);
        }
        public void Logout()
        {
            Preferences.Default.Remove(AuthStateKey);
        }
    }
}

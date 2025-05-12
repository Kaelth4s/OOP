using System.Text.Json;

namespace OOP.Lab5.AuthServices
{
    public class AuthService : IAuthService
    {
        private const string _AUTH_FILE = "C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab5/" + "current_user.json";

        public User? CurrentUser { get; private set; }

        public bool IsAuthenticated => CurrentUser != null;

        public AuthService()
        {
            LoadCurrentUser();
        }

        public void SignIn(User user)
        {
            CurrentUser = user;
            File.WriteAllText(_AUTH_FILE, JsonSerializer.Serialize(user));
        }

        public void SignOut()
        {
            CurrentUser = null;
            if (File.Exists(_AUTH_FILE))
            {
                File.Delete(_AUTH_FILE);
            }
        }

        private void LoadCurrentUser()
        {
            if (File.Exists(_AUTH_FILE))
            {
                string json = File.ReadAllText(_AUTH_FILE);
                CurrentUser = JsonSerializer.Deserialize<User>(json);
            }
        }
    }
}

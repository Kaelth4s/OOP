using System.Text.Json;
using OOP.Lab5.DataRepositories;

namespace OOP.Lab5.AuthServices
{
    public class AuthService : IAuthService
    {
        private readonly string _AUTH_FILE_PATH;
        private const string _AUTH_FILE_NAME = "current_user_id.json";
        private readonly DataRepository<User> _USER_REPOSITORY;

        public User? CurrentUser { get; private set; }

        public bool IsAuthenticated => CurrentUser != null;

        public AuthService(string authFilePath, DataRepository<User> userRepository)
        {
            _AUTH_FILE_PATH = authFilePath + _AUTH_FILE_NAME;
            _USER_REPOSITORY = userRepository;
            LoadCurrentUser();
        }

        public void SignIn(User user)
        {
            CurrentUser = user;
            try
            {
                File.WriteAllText(_AUTH_FILE_PATH, JsonSerializer.Serialize(user.Id));
            }
            catch (Exception)
            {
                throw;
            }
            Console.WriteLine($"Авторизован пользователь {user.Name}");
        }

        public void SignOut()
        {
            CurrentUser = null;
            try
            {
                File.Delete(_AUTH_FILE_PATH);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadCurrentUser()
        {
            string json;
            try
            {
                json = File.ReadAllText(_AUTH_FILE_PATH);
            }
            catch (FileNotFoundException) 
            {
                return;
            }
            catch (Exception)
            {
                throw;
            }
            CurrentUser = _USER_REPOSITORY.GetById(JsonSerializer.Deserialize<int>(json));
            Console.WriteLine($"Автоматически авторизован: {CurrentUser!.Name}");
        }
    }
}

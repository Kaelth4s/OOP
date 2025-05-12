using OOP.Lab5.DataRepositories;

namespace OOP.Lab5.UserRepositories
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {
        public UserRepository(string filePath) : base(filePath) { }

        public User? GetByLogin(string login)
        {
            return _items.FirstOrDefault(_ => _.Login == login);
        }
    }
}

namespace OOP.Lab5
{
    public interface IUserRepository : IDataRepository<User>
    {
        User? GetByLogin(string login);
    }
}

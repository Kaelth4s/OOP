namespace OOP.Lab5
{
    public interface IAuthService
    {
        void SignIn(User user);
        void SignOut();
        bool IsAuthenticated { get; }
        User? CurrentUser { get; }
    }
}

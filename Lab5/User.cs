namespace OOP.Lab5
{
    public record User : IComparable<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public User(int id, string name, string login, string password, string? email = null, string? address = null)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
            Email = email;
            Address = address;
        }

        public int CompareTo(User? other)
        {
            return string.Compare(Name, other?.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"User(Id={Id}, Name={Name}, Login={Login}, Email={Email}, Address={Address})";
        }
    }
}

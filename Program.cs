using OOP.Lab1;
using OOP.Lab2;
using OOP.Lab3.LogFilters;
using OOP.Lab3.LogHandlers;
using OOP.Lab3;
using System.Text.RegularExpressions;
using OOP.Lab4.NotifyDataChanged;
using OOP.Lab4.NotifyDataChanging;
using OOP.Lab4.PropertyChangedListeners;
using OOP.Lab4.PropertyChangingListeners;
using OOP.Lab5.UserRepositories;
using OOP.Lab5.AuthServices;
using OOP.Lab5;
using OOP.Lab6.Commands;
using OOP.Lab6;
using OOP.Lab7.Configs;
using OOP.Lab7;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Lab1
            //Point2d point1 = new Point2d(1, 2);
            //Point2d point2 = new Point2d(1, 2);
            //if (point1 == point2) Console.WriteLine(point1.ToStringRepresents());

            //Vector2d vector1 = new Vector2d(1, 2);
            //Vector2d vector2 = new Vector2d(2, 2);
            //Vector2d vector3 = vector1 * 2;
            //Console.WriteLine(vector3.ToStringRepresents());
            //foreach (int n in vector1)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine(Vector2d.Dot(vector2, vector1));
            //Console.WriteLine(vector1[1]);



            // Lab2
            //Printer.Print("lab", Color.GREEN, (5, 5), "%");
            //Console.WriteLine("test");
            //using (Printer printer = new(Color.RED, (4, 17), "|"))
            //{
            //    printer.Print("using text");
            //}
            //Console.WriteLine("test2");



            // Lab3
            //List<ILogFilter> filters = new()
            //{
            //    new SimpleLogFilter("ERROR"),
            //    new ReLogFilter(new Regex(@"\d{4}"))
            //};

            //List<ILogHandler> handlers = new()
            //{
            //    new ConsoleHandler(),
            //    new FileHandler("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab3/log.txt"),
            //    new SyslogHandler(),
            //    new SocketHandler()
            //};

            //Logger logger = new(filters, handlers);

            //logger.Log("ERROR: 1283 fatal errors");
            //logger.Log("ERROR: 123 fatal errors");
            //logger.Log("ERROR: 3942 test");
            //logger.Log("INFO: test 1234");



            // Lab4
            //ConcreteObservable concreteObservable = new();
            //ConcreteValidating concreteValidating = new();

            //ConsoleChangedListener consoleLogger = new();
            //FileChangedListener fileLogger = new();

            //FirstAttributeValidator firstAttributeValidator = new();

            //concreteObservable.AddPropertyChangedListener(consoleLogger);
            //concreteObservable.AddPropertyChangedListener(fileLogger);

            //concreteValidating.AddPropertyChangingListener(firstAttributeValidator);

            //concreteValidating.Attribute1 = "123";
            //Console.WriteLine(concreteValidating.Attribute1);
            //concreteValidating.Attribute1 = "12";
            //Console.WriteLine(concreteValidating.Attribute1);
            ////concreteValidating.Attribute1 = "1";
            //concreteValidating.RemovePropertyChangingListener(firstAttributeValidator);
            //concreteValidating.Attribute1 = "1";
            //Console.WriteLine(concreteValidating.Attribute1);

            //concreteObservable.Attribute1 = "test";
            //concreteObservable.Attribute2 = 123;



            // Lab5
            //UserRepository userRepository = new("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab5/" + "users.json");
            //AuthService authService = new();

            //if (authService.IsAuthenticated)
            //{
            //    Console.WriteLine($"Автоматически авторизован: {authService.CurrentUser!.Name}");
            //    Console.WriteLine("Желаете сменить пользователя? (y/n)");
            //    string answer = Console.ReadLine();
            //    if (answer == "y")
            //    {
            //        Console.WriteLine("Введите логин пользователя:");
            //        User userToAuth = userRepository.GetByLogin(Console.ReadLine());
            //        if (userToAuth != null && Console.ReadLine() == userToAuth.Password)
            //        {
            //            authService.SignIn(userToAuth);
            //            Console.WriteLine($"Авторизован пользователь {userToAuth.Name}");
            //        }
            //    }
            //    else if (answer == "n")
            //        authService.SignOut();
            //}
            //else
            //{
            //    Console.WriteLine("Нет авторизованного пользователя");

            //    User newUser = new(0, "Artem", "Archkael", "qwerty");
            //    userRepository.Add(newUser);
            //    Console.WriteLine($"Добавлен новый пользователь {newUser.Name}");

            //    User newUser1 = new(1, "Stepan", "Stepanella", "qwerty1");
            //    userRepository.Add(newUser1);
            //    Console.WriteLine($"Добавлен новый пользователь {newUser1.Name}");

            //    User updatedUser = newUser with { Email = "archieshn@gmail.com" };
            //    userRepository.Update(updatedUser);
            //    Console.WriteLine($"Обновлена почта пользователя {updatedUser.Name}, текущее значение: {updatedUser.Email}");

            //    User userToAuth = userRepository.GetByLogin("Archkael");
            //    if (userToAuth != null && Console.ReadLine() == userToAuth.Password)
            //    {
            //        authService.SignIn(userToAuth);
            //        Console.WriteLine($"Авторизован пользователь {userToAuth.Name}");
            //    }
            //}



            // Lab6
            //File.WriteAllText("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab6/output.txt", "");
            //Console.WriteLine("\nRestoring bindings:");
            //Keyboard keyboard = new();
            //KeyboardStateSaver saver = new();
            //keyboard.RestoreBindings(saver.LoadState());

            ////Keyboard keyboard = new();
            ////KeyboardStateSaver saver = new();

            ////List<char> buffer = keyboard.GetTextBuffer();

            ////keyboard.BindKey("a", new PrintCharCommand('a', buffer));
            ////keyboard.BindKey("b", new PrintCharCommand('b', buffer));
            ////keyboard.BindKey("c", new PrintCharCommand('c', buffer));
            ////keyboard.BindKey("d", new PrintCharCommand('d', buffer));
            ////keyboard.BindKey("ctrl++", new VolumeUpCommand());
            ////keyboard.BindKey("ctrl+-", new VolumeDownCommand());
            ////keyboard.BindKey("ctrl+p", new MediaPlayerCommand());

            ////saver.SaveState(keyboard);

            //keyboard.PressKey("a");
            //keyboard.PressKey("b");
            //keyboard.PressKey("c");

            //keyboard.Undo();
            //keyboard.Undo();
            //keyboard.Redo();

            //keyboard.PressKey("ctrl++");
            //keyboard.PressKey("ctrl+-");
            //keyboard.PressKey("ctrl+p");

            //keyboard.PressKey("d");

            //keyboard.Undo();
            //keyboard.Undo();



            // Lab7
            //Injector injector = new();

            //Console.WriteLine("==== Using Config A ====");
            //ConfigA.Configure(injector);

            //using (var scope = new Scope(injector))
            //{
            //    var i3_1 = injector.GetInstance<IInterface3>();
            //    var i3_2 = injector.GetInstance<IInterface3>();
            //    Console.WriteLine($"Same IInterface3 in scope? {ReferenceEquals(i3_1, i3_2)}");

            //    i3_1.Run();
            //}

            //Console.WriteLine("\n==== Using Config B ====");
            //injector = new();
            //ConfigB.Configure(injector);

            //using (var scope = new Scope(injector))
            //{
            //    var i3_1 = injector.GetInstance<IInterface3>();
            //    var i3_2 = injector.GetInstance<IInterface3>();
            //    Console.WriteLine($"Same IInterface3 in scope? {ReferenceEquals(i3_1, i3_2)}");

            //    i3_1.Run();
            //}
        }
    }
}

namespace OOP.Lab3.LogHandlers
{
    public class ConsoleHandler : ILogHandler
    {
        public void Handle(string text)
        {
            Console.WriteLine(DateTime.Now.ToString() + " " + text);
        }
    }
}

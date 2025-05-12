namespace OOP.Lab3.LogHandlers
{
    public class FileHandler : ILogHandler
    {
        private readonly string _FILE_PATH;

        public FileHandler(string filePath)
        {
            _FILE_PATH = filePath;
        }

        public void Handle(string text)
        {
            File.AppendAllText(_FILE_PATH, DateTime.Now.ToString() + " " + text + "\n");
        }
    }
}

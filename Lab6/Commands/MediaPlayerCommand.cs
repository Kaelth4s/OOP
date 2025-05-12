namespace OOP.Lab6.Commands
{
    public class MediaPlayerCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Media player launched");
            File.AppendAllText("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab6/output.txt", "Media player launched\n");
        }

        public void Undo()
        {
            Console.WriteLine("Media player closed");
            File.AppendAllText("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab6/output.txt", "Media player closed\n");
        }
    }
}

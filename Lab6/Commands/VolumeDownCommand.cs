namespace OOP.Lab6.Commands
{
    public class VolumeDownCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Volume decreased -20%");
            File.AppendAllText("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab6/output.txt", "Volume decreased -20%\n");
        }

        public void Undo()
        {
            Console.WriteLine("Volume increased +20%");
            File.AppendAllText("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab6/output.txt", "Volume increased +20%\n");
        }
    }
}

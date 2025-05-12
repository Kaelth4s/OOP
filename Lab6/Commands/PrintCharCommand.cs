namespace OOP.Lab6.Commands
{
    public class PrintCharCommand : ICommand
    {
        private char _character;
        private List<char> _textBuffer;

        public PrintCharCommand(char character, List<char> textBuffer)
        {
            _character = character;
            _textBuffer = textBuffer;
        }

        public void Execute()
        {
            _textBuffer.Add(_character);
            Console.WriteLine(_character);
            string text = "";
            foreach (char c in _textBuffer) text += c;
            File.AppendAllText("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab6/output.txt", text + "\n");
        }

        public void Undo()
        {
            if (_textBuffer.Count > 0)
            {
                _textBuffer.RemoveAt(_textBuffer.Count - 1);
                Console.WriteLine("undo");
                string text = "";
                foreach (char c in _textBuffer) text += c;
                File.AppendAllText("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab6/output.txt", text + "\n");
            }
        }
    }
}

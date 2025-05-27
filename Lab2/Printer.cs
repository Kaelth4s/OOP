namespace OOP.Lab2
{
    public class Printer : IDisposable
    {
        private readonly Color _COLOR;
        private readonly (int, int) _POSITION;
        private readonly string _SYMBOL;
        private static readonly Dictionary<char, string[]> _FONT = LoadFont("font2.txt");

        public Printer(Color color, (int, int) position, string symbol)
        {
            _COLOR = color;
            _POSITION = position;
            _SYMBOL = symbol;
            Console.Write($"\u001b[s");
        }

        public void Print(string text)
        {
            Console.SetCursorPosition(_POSITION.Item1, _POSITION.Item2);
            Console.Write($"\u001b[{(int)_COLOR}m");

            string[] outputText = BuildText(text.ToUpper(), _SYMBOL);
            int lineCount = 0;

            foreach (string line in outputText)
            {
                Console.SetCursorPosition(_POSITION.Item1, _POSITION.Item2 + lineCount);
                Console.WriteLine(line);
                lineCount++;
            }
        }

        public void Dispose()
        {
            Console.Write($"\u001b[u");
            Console.Write($"\u001b[{(int)Color.WHITE}m");
        }

        public static void Print(string text, Color color, (int, int) position, string symbol)
        {
            Console.SetCursorPosition(position.Item1, position.Item2);
            Console.Write($"\u001b[{(int)color}m");

            string[] outputText = BuildText(text.ToUpper(), symbol);
            int lineCount = 0;

            foreach (string line in outputText)
            {
                Console.SetCursorPosition(position.Item1, position.Item2 + lineCount);
                Console.WriteLine(line);
                lineCount++;
            }

            Console.Write($"\u001b[{(int)Color.WHITE}m");
        }

        private static string[] BuildText(string text, string symbol)
        {
            int height = _FONT['A'].Length;
            string[] outputText = new string[height];

            for (int i = 0; i < height; i++)
            {
                outputText[i] = "";
            }

            foreach (char letter in text)
            {
                if (!_FONT.ContainsKey(letter)) continue;

                for (int i = 0; i < height; i++)
                {
                    outputText[i] += _FONT[letter][i].Replace("*", symbol) + "  ";
                }
            }

            return outputText;
        }
        private static Dictionary<char, string[]> LoadFont(string fileName)
        {
            Dictionary<char, string[]> font = new();
            string path = Directory.GetCurrentDirectory();
            path = path.Remove(path.IndexOf("OOP") + 3) + "\\Lab2\\";
            string[] lines = File.ReadAllLines(path + fileName);

            for (int i = 0; i < lines.Length;)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    i++;
                    continue;
                }

                char letter = lines[i][0];
                i++;
                List<string> letterLines = new();

                while (i < lines.Length && !string.IsNullOrWhiteSpace(lines[i]))
                {
                    letterLines.Add(lines[i]);
                    i++;
                }

                font[letter] = letterLines.ToArray();
            }

            return font;
        }
    }

    public enum Color
    {
        BLACK = 30,
        RED = 31,
        GREEN = 32,
        YELLOW = 33,
        BLUE = 34,
        MAGENTA = 35,
        CYAN = 36,
        WHITE = 37
    }
}
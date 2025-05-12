using System.Text.Json;

namespace OOP.Lab6
{
    public class KeyboardStateSaver
    {
        private const string Path = "C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab6/bindings.json";

        public void SaveState(Keyboard keyboard)
        {
            Dictionary<string, string> data = keyboard.GetBindingsForSave();
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Path, json);
        }

        public Dictionary<string, string> LoadState()
        {
            if (!File.Exists(Path)) return new();
            string json = File.ReadAllText(Path);
            return JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new();
        }
    }
}

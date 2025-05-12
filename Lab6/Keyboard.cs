using OOP.Lab6.Commands;

namespace OOP.Lab6
{
    public class Keyboard
    {
        private Dictionary<string, ICommand> _keyBindings = new();
        private Stack<ICommand> _undoStack = new();
        private Stack<ICommand> _redoStack = new();
        private List<char> _textBuffer = new();

        public void BindKey(string key, ICommand command)
        {
            _keyBindings[key] = command;
        }

        public void PressKey(string key)
        {
            if (_keyBindings.ContainsKey(key))
            {
                ICommand command = _keyBindings[key];
                command.Execute();
                _undoStack.Push(command);
                _redoStack.Clear();
            }
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                ICommand command = _undoStack.Pop();
                command.Undo();
                _redoStack.Push(command);
            }
        }

        public void Redo()
        {
            if ( _redoStack.Count > 0)
            {
                ICommand command = _redoStack.Pop();
                command.Execute();
                _undoStack.Push(command);
            }
        }

        public Dictionary<string, string> GetBindingsForSave()
        {
            Dictionary<string, string> result = new();
            foreach (KeyValuePair<string, ICommand> pair in _keyBindings)
            {
                result[pair.Key] = pair.Value.GetType().Name;
            }
            return result;
        }

        public void RestoreBindings(Dictionary<string, string> bindings)
        {
            foreach (KeyValuePair<string, string> pair in bindings)
            {
                switch (pair.Value)
                {
                    case nameof(PrintCharCommand):
                        BindKey(pair.Key, new PrintCharCommand(pair.Key[0], _textBuffer));
                        break;
                    case nameof(VolumeUpCommand):
                        BindKey(pair.Key, new VolumeUpCommand());
                        break;
                    case nameof(VolumeDownCommand):
                        BindKey(pair.Key, new VolumeDownCommand());
                        break;
                    case nameof(MediaPlayerCommand):
                        BindKey(pair.Key, new MediaPlayerCommand());
                        break;
                }
            }
        }
        
        public List<char> GetTextBuffer()
        {
            return _textBuffer;
        }
    }
}

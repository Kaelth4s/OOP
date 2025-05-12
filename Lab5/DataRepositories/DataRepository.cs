using System.Text.Json;

namespace OOP.Lab5.DataRepositories
{
    public class DataRepository<T> : IDataRepository<T> where T : class
    {
        private readonly string _FILE_PATH;
        protected List<T> _items;

        public DataRepository(string filePath)
        {
            _FILE_PATH = filePath;
            _items = Load();
        }

        private List<T> Load()
        {
            if (!File.Exists(_FILE_PATH)) return new List<T>();
            string json = File.ReadAllText(_FILE_PATH);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        private void Save()
        {
            File.WriteAllText(_FILE_PATH, JsonSerializer.Serialize(_items));
        }

        public void Add(T item)
        {
            if (!_items.Contains(item)) _items.Add(item);
            Save();
        }

        public void Delete(T item)
        {
            _items.Remove(item);
            Save();
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T? GetById(int id)
        {
            return _items.FirstOrDefault(_ => (int)_?.GetType().GetProperty("Id")!.GetValue(_)! == id);
        }

        public void Update(T item)
        {
            int id = (int)item.GetType().GetProperty("Id")!.GetValue(item)!;
            var index = _items.FindIndex(_ => (int)_?.GetType().GetProperty("Id")!.GetValue(_)! == id);
            if (index >= 0)
            {
                _items[index] = item;
                Save();
            }
        }
    }
}

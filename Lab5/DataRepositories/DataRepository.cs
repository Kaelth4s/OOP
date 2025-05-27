using System.Reflection;
using System.Text.Json;

namespace OOP.Lab5.DataRepositories
{
    public class DataRepository<T> : IDataRepository<T> where T : class
    {
        private readonly string _FILE_PATH;
        private const string _FILE_NAME = "users.json";
        protected List<T> _items;

        public DataRepository(string filePath)
        {
            _FILE_PATH = filePath + _FILE_NAME;
            _items = Load();
        }

        private List<T> Load()
        {
            if (!File.Exists(_FILE_PATH)) return new List<T>();
            string json;
            try
            {
                json = File.ReadAllText(_FILE_PATH);
            }
            catch (Exception)
            {
                throw;
            }
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        private void Save()
        {
            try
            {
                File.WriteAllText(_FILE_PATH, JsonSerializer.Serialize(_items));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Add(T item)
        {
            if (!(GetById((int)item.GetType().GetProperty("Id")!.GetValue(item)!) is null)) return;
            _items.Add(item);
            Save();
            Console.WriteLine($"Добавлен новый пользователь {item.GetType().GetProperty("Name")!.GetValue(item)?.ToString()}");
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
                PropertyInfo[] itemProperties = item.GetType().GetProperties();
                if (!itemProperties.All(property => property.GetValue(item)?.ToString() == property.GetValue(_items[index])?.ToString())) 
                {
                    Console.WriteLine($"Обновлён пользователь {item.GetType().GetProperty("Name")!.GetValue(item)?.ToString()}");
                    Console.WriteLine($"Было {_items[index].ToString()}");
                    Console.WriteLine($"Стало {item.ToString()}");
                    _items[index] = item;
                    Save();
                }
            }
        }
    }
}

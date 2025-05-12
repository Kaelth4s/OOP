using OOP.Lab4.NotifyDataChanged;

namespace OOP.Lab4.PropertyChangedListeners
{
    public class FileChangedListener : IPropertyChangedListener<ConcreteObservable>
    {
        public void OnPropertyChanged(ConcreteObservable obj, object property, string propertyName)
        {
            File.AppendAllText("C:/Users/Archkael/Projects/IKBFU Projects/Visual Studio/OOP/Lab4/log.txt", DateTime.Now.ToString() + " " + "Свойство \'" + propertyName + $"\' изменилось у {obj}. Текущее значение: " + property.ToString() + "\n");
        }
    }
}

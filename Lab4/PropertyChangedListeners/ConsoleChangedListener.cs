using OOP.Lab4.NotifyDataChanged;

namespace OOP.Lab4.PropertyChangedListeners
{
    public class ConsoleChangedListener : IPropertyChangedListener<ConcreteObservable>
    {
        public void OnPropertyChanged(ConcreteObservable obj, object property, string propertyName)
        {
            Console.WriteLine(DateTime.Now.ToString() + " " + "Свойство \'" + propertyName + $"\' изменилось у {obj}. Текущее значение: " + property.ToString());
        }
    }
}

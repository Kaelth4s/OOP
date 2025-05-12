using OOP.Lab4.NotifyDataChanging;

namespace OOP.Lab4.PropertyChangingListeners
{
    public class FirstAttributeValidator : IPropertyChangingListener<ConcreteValidating>
    {
        public bool OnPropertyChanging(ConcreteValidating obj, string propertyName, object oldValue, object newValue)
        {
            if (propertyName == nameof(ConcreteValidating.Attribute1))
            {
                string newAttribute1 = (string)newValue;
                if (newAttribute1.Length < 2 || newAttribute1.Length > 5)
                {
                    throw new ArgumentException("Недопустимый аттрибут 1");
                }
            }
            return true;
        }
    }
}

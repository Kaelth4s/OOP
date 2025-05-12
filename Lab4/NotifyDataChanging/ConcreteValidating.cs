namespace OOP.Lab4.NotifyDataChanging
{
    public class ConcreteValidating : INotifyDataChanging<ConcreteValidating>
    {
        private List<IPropertyChangingListener<ConcreteValidating>> _changingListeners = new();

        private string _attribute1;
        public string Attribute1
        {
            get { return _attribute1; }
            set
            {
                if (NotifyPropertyChanging(nameof(Attribute1), _attribute1, value))
                {
                    _attribute1 = value;
                }
            }
        }

        private int _attribute2;
        public int Attribute2
        {
            get { return _attribute2; }
            set
            {
                if (NotifyPropertyChanging(nameof(Attribute2), _attribute2, value))
                {
                    _attribute2 = value; 
                }
            }
        }

        public void AddPropertyChangingListener(IPropertyChangingListener<ConcreteValidating> listener)
        {
            _changingListeners.Add(listener);
        }

        public void RemovePropertyChangingListener(IPropertyChangingListener<ConcreteValidating> listener)
        {
            _changingListeners.Remove(listener);
        }

        private bool NotifyPropertyChanging(string propertyName, object oldValue, object newValue)
        {
            foreach (IPropertyChangingListener<ConcreteValidating> listener in _changingListeners)
            {
                if (!listener.OnPropertyChanging(this, propertyName, oldValue, newValue)) 
                    return false;
            }
            return true;
        }
    }
}

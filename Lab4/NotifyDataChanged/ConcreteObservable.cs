namespace OOP.Lab4.NotifyDataChanged
{
    public class ConcreteObservable : INotifyDataChanged<ConcreteObservable>
    {
        private List<IPropertyChangedListener<ConcreteObservable>> _listeners = new();

        private string _attribute1;
        public string Attribute1
        {
            get { return _attribute1; }
            set
            {
                _attribute1 = value;
                NotifyPropertyChanged(Attribute1, nameof(Attribute1));
            }
        }

        private int _attribute2;
        public int Attribute2
        {
            get { return _attribute2; }
            set
            {
                _attribute2 = value;
                NotifyPropertyChanged(Attribute2, nameof(Attribute2));
            }
        }

        public void AddPropertyChangedListener(IPropertyChangedListener<ConcreteObservable> listener)
        {
            _listeners.Add(listener);
        }

        public void RemovePropertyChangedListener(IPropertyChangedListener<ConcreteObservable> listener)
        {
            _listeners.Remove(listener);
        }

        private void NotifyPropertyChanged(object property, string propertyName) 
        {
            foreach (IPropertyChangedListener<ConcreteObservable> listener in _listeners)
            {
                listener.OnPropertyChanged(this, property, propertyName);
            }
        }
    }
}

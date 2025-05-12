namespace OOP.Lab4
{
    public interface IPropertyChangedListener<T>
    {
        void OnPropertyChanged(T obj, object property, string propertyName);
    }
}

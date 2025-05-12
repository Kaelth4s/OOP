namespace OOP.Lab4
{
    public interface IPropertyChangingListener<T>
    {
        bool OnPropertyChanging(T obj, string propertyName, object oldValue, object newValue);
    }
}

namespace OOP.Lab4
{
    public interface INotifyDataChanged<T>
    {
        void AddPropertyChangedListener(IPropertyChangedListener<T> listener);
        void RemovePropertyChangedListener(IPropertyChangedListener<T> listener);
    }
}

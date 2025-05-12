namespace OOP.Lab4
{
    public interface INotifyDataChanging<T>
    {
        void AddPropertyChangingListener(IPropertyChangingListener<T> listener);
        void RemovePropertyChangingListener(IPropertyChangingListener<T> listener);
    }
}

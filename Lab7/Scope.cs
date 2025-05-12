namespace OOP.Lab7
{
    public class Scope : IDisposable
    {
        private readonly Injector _injector;
        internal Dictionary<Type, object> ScopedInstances = new();

        public Scope(Injector injector)
        {
            _injector = injector;
            _injector.PushScope(this);
        }

        public void Dispose()
        {
            _injector.PopScope();
        }
    }
}

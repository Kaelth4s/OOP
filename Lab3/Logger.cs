namespace OOP.Lab3
{
    public class Logger
    {
        private readonly List<ILogFilter> _FILTERS;
        private readonly List<ILogHandler> _HANDLERS;

        public Logger(List<ILogFilter> filters, List<ILogHandler> handlers)
        {
            _FILTERS = filters;
            _HANDLERS = handlers;
        }

        public void Log(string text)
        {
            if (_FILTERS.All(_ => _.Match(text)))
            {
                foreach (ILogHandler handler in _HANDLERS)
                {
                    handler.Handle(text);
                }
            }
        }
    }
}

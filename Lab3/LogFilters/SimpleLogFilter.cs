namespace OOP.Lab3.LogFilters
{
    public class SimpleLogFilter : ILogFilter
    {
        private readonly string _PATTERN;

        public SimpleLogFilter(string pattern)
        {
            _PATTERN = pattern;
        }

        public bool Match(string text)
        {
            return text.Contains(_PATTERN);
        }
    }
}

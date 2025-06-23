using System.Text.RegularExpressions;

namespace OOP.Lab3.LogFilters
{
    public class ReLogFilter : ILogFilter
    {
        private readonly Regex _PATTERN;

        public ReLogFilter(Regex pattern)
        {
            _PATTERN = pattern;
        }

        public bool Match(string text)
        {
            try
            {
                return _PATTERN.IsMatch(text);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

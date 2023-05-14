using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool Includes(
            this string? source,
            string? value,
            StringComparison comparison = StringComparison.OrdinalIgnoreCase
        )
        {
            if (string.IsNullOrEmpty(source))
                return false;
            if (string.IsNullOrEmpty(value))
                return false;

            return source.Contains(value, comparison);
        }

        public static string RemoveWhitespaceCharacters(this string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var pattern = "\\s+";
                var newValue = Regex.Replace(value, pattern, "");
                return newValue;
            }

            return value;
        }
    }
}

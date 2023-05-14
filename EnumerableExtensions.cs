namespace ExtensionMethods
{
    public static class EnumerableExtensions
    {
        public static string Join(this IEnumerable<string> sequence, string separator = ", ")
            => string.Join(separator, sequence);
    }
}

namespace ExtensionMethods
{
    public static class HttpRequestMessageExtensions
    {
        public static void AddHeadersWithoutValidation(
            this HttpRequestMessage request,
            Dictionary<string, string> headers
        )
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            request.Headers.Clear();

            foreach (var kvp in headers)
            {
                if (!string.IsNullOrWhiteSpace(kvp.Value))
                    request.Headers.TryAddWithoutValidation(kvp.Key, kvp.Value);
            }
        }
    }
}

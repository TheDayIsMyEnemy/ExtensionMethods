using System.Net;
using System.Text.Json;

namespace ExtensionMethods
{
    public static class HttpClientExtensions
    {
        public static async Task<(T?, HttpStatusCode)> GetAsync<T>(
            this HttpClient httpClient,
            string requestUri
        )
            where T : class, new()
        {
            T? obj = new();
            var response = await httpClient.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                obj = JsonSerializer.Deserialize<T>(responseBody);
            }
            return (obj, response.StatusCode);
        }

        // public static async Task<(TResponse, HttpStatusCode)> PostAsync<TRequest>(this HttpClient client,)

        public static void AddDefaultRequestHeaders(
            this HttpClient client,
            Dictionary<string, string> headers
        )
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            foreach (var kvp in headers)
            {
                if (!string.IsNullOrWhiteSpace(kvp.Value))
                    client.DefaultRequestHeaders.Add(kvp.Key, kvp.Value);
            }
        }
    }
}

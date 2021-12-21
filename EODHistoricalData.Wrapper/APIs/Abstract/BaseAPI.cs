using Newtonsoft.Json;

using System.Net;

namespace EOD.APIs.Abstract
{
    internal abstract class BaseAPI : IDisposable
    {
        private readonly string _apiToken;
        private readonly HttpClient _httpClient;


        public BaseAPI(string apiToken, bool useProxy = false)
        {
            _apiToken = apiToken;

            if (useProxy)
            {
                HttpClientHandler myHandler = new();
                myHandler.DefaultProxyCredentials = CredentialCache.DefaultCredentials;
                _httpClient = new HttpClient(myHandler);
            }
            else
            {
                _httpClient = new HttpClient();
            }

        }

        public async Task<T> ExecuteQueryAsync<T>(string uri)
        {
            if (!string.IsNullOrEmpty(_apiToken))
            {
                if (uri.Contains('?'))
                {
                    uri += $"&api_token={_apiToken}";
                }
                else
                {
                    uri += $"?api_token={_apiToken}";
                }

            }
            HttpResponseMessage? response = await _httpClient.GetAsync(uri);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"There was an error while executing the HTTP query. Reason: {response.ReasonPhrase}");
            }

            string content = await response.Content.ReadAsStringAsync();
            T? result = JsonConvert.DeserializeObject<T>(content);
            if (result == null) throw new NullReferenceException();
            return result;
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}

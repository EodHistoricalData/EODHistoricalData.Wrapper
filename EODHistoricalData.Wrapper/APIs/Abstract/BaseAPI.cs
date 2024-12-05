using EODHistoricalData.Wrapper.Utils;
using Newtonsoft.Json;

using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	internal abstract class BaseAPI : IDisposable
	{
		private readonly string _apiToken;
		private readonly HttpClient _httpClient;

		public BaseAPI(string apiToken, IWebProxy proxy = null, string source = null)
		{
			_apiToken = apiToken;

			if (proxy != null)
			{
				HttpClientHandler myHandler = new HttpClientHandler();
				myHandler.Proxy = proxy;
				_httpClient = new HttpClient(myHandler);
			}
			else
			{
				_httpClient = new HttpClient();
			}

			_httpClient.Timeout = TimeSpan.FromMinutes(10);

			if (String.IsNullOrEmpty(source))
			{
				_httpClient.DefaultRequestHeaders.Add("User-Agent", "eodhistoricaldata.wrapper");
			}
			else
			{
				_httpClient.DefaultRequestHeaders.Add("User-Agent", source);
			}
		}

		public async Task<T> ExecuteQueryAsync<T>(string uri)
		{
			if (!string.IsNullOrEmpty(_apiToken))
			{
				if (uri.Contains("?"))
				{
					uri += $"&api_token={_apiToken}";
				}
				else
				{
					uri += $"?api_token={_apiToken}";
				}
			}

			HttpResponseMessage response = await _httpClient.GetAsync(uri);
			if (!response.IsSuccessStatusCode)
			{
				throw new HttpRequestExceptionExtended($"There was an error while executing the HTTP query. Reason: {response.ReasonPhrase}", response.StatusCode);
			}

			string content = await response.Content.ReadAsStringAsync();
			T result = JsonConvert.DeserializeObject<T>(content);
			if (result == null) throw new NullReferenceException();
			return result;
		}

		public void Dispose()
		{
			_httpClient?.Dispose();
		}
	}
}

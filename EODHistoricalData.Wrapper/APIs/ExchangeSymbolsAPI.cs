using EOD.APIs.Abstract;
using EOD.Model;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class ExchangeSymbolsAPI : BaseAPI, IExchangeSymbolsAPI
	{
		private const string source = @"https://eodhistoricaldata.com/api/exchange-symbol-list/{0}?fmt=json";

		public ExchangeSymbolsAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

		public async Task<List<ExchangeSymbol>> GetExchangeSymbolsAsync(string code)
		{
			object[] args = new object[]
			{
				code
			};
			string uri = string.Format(source, args);
			return await ExecuteQueryAsync<List<ExchangeSymbol>>(uri);
		}
	}
}

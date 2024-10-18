using EOD.APIs.Abstract;
using EOD.Model.ExchangeDetails;

using System;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class ExchangeDetailsAPI : BaseAPI, IExchangeDetailsAPI
	{
		private const string source = @"https://eodhistoricaldata.com/api/exchange-details/{0}?";

		public ExchangeDetailsAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

		public async Task<ExchangeDetail> GetExchangeDetailsAsync(string code, DateTime? from = null, DateTime? to = null)
		{
			string uri = source;
			if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
			if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";

			object[] args = new object[]
			{
				code
			};
			string url = string.Format(uri, args);
			return await ExecuteQueryAsync<ExchangeDetail>(url);
		}
	}
}

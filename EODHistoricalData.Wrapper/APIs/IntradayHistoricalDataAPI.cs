using EOD.APIs.Abstract;
using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class IntradayHistoricalDataAPI : BaseAPI, IIntradayHistoricalDataAPI
	{
		private const string source = @"https://eodhistoricaldata.com/api/intraday/{0}?from={1}&to={2}&interval={3}&fmt=json";
		public IntradayHistoricalDataAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }
		public async Task<List<IntradayHistoricalStockPrice>> GetDataAsync(string ticker, DateTime from, DateTime to, string interval)
		{
			object[] args = new object[]
			{
				ticker,
				((DateTimeOffset)from).ToUnixTimeSeconds(),
				((DateTimeOffset)to).ToUnixTimeSeconds(),
				interval
			};
			string url = string.Format(source, args);
			return await ExecuteQueryAsync<List<IntradayHistoricalStockPrice>>(url);

		}
	}
}

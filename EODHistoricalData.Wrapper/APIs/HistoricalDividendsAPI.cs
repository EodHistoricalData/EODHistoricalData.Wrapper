using EOD.APIs.Abstract;
using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class HistoricalDividendsAPI : BaseAPI, IHistoricalDividendsAPI
	{
		private const string sourceDividends = @"https://eodhistoricaldata.com/api/div/{0}?&fmt=json";

		public HistoricalDividendsAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }


		public async Task<List<HistoricalDividend>> GetDataAsync(string ticker, DateTime? from, DateTime? to)
		{
			object[] args = new object[]
			{
				ticker
			};
			string url = string.Format(sourceDividends, args);

			if (from != null) url += $"&from={from?.ToString("yyyy-MM-dd")}";
			if (to != null) url += $"&to={to?.ToString("yyyy-MM-dd")}";

			return await ExecuteQueryAsync<List<HistoricalDividend>>(url);

		}

		private const string sourceSplits = @"https://eodhistoricaldata.com/api/splits/{0}?&fmt=json";
		public async Task<List<HistoricalSplit>> GetHistoricalSplitsAsync(string ticker, DateTime? from, DateTime? to)
		{
			object[] args = new object[]
			{
				ticker
			};
			string url = string.Format(sourceSplits, args);

			if (from != null) url += $"&from={from?.ToString("yyyy-MM-dd")}";
			if (to != null) url += $"&to={to?.ToString("yyyy-MM-dd")}";

			return await ExecuteQueryAsync<List<HistoricalSplit>>(url);

		}
	}
}

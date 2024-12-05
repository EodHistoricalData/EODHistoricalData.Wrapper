using EOD.APIs.Abstract;
using EOD.Model.Bulks;

using EODHistoricalData.Wrapper.Model.Bulks;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class BulkAPI : BaseAPI, IBulkAPI
	{
		private const string source = @"https://eodhistoricaldata.com/api/eod-bulk-last-day/{0}?&fmt=json";

		public BulkAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

		public async Task<List<Bulk>> GetBulksAsync(string code, BulkQueryTypes type, DateTime? date, string symbols)
		{
			string uri = source;

			uri += GetTypeUrlString(type);
			if (date != null) uri += $"&date={date?.ToString("yyyy-MM-dd")}";
			if (!string.IsNullOrEmpty(symbols)) uri += $"&symbols={symbols}";

			object[] args = new object[]
			{
				code,

			};
			string url = string.Format(uri, args);
			return await ExecuteQueryAsync<List<Bulk>>(url);
		}

		public async Task<List<ExtendedBulk>> GetExtendedBulksAsync(string code, BulkQueryTypes type, DateTime? date, string symbols)
		{
			string uri = source;
			uri += "&filter=extended";
			uri += GetTypeUrlString(type);
			if (date != null) uri += $"&date={date?.ToString("yyyy-MM-dd")}";
			if (!string.IsNullOrEmpty(symbols)) uri += $"&symbols={symbols}";

			object[] args = new object[]
			{
				code,

			};
			string url = string.Format(uri, args);
			return await ExecuteQueryAsync<List<ExtendedBulk>>(url);
		}

		private string GetTypeUrlString(BulkQueryTypes type)
		{
			switch (type)
			{
				case BulkQueryTypes.EndOfDay:
					return "";
				case BulkQueryTypes.Splits:
					return $"&type=splits";

				case BulkQueryTypes.Dividents:
					return $"&type=dividends";
				default:
					return "";
			}
		}
	}
}

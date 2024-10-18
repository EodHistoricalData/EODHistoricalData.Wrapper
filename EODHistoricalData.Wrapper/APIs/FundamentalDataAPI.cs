using EOD.APIs.Abstract;
using EOD.Model.BulkFundamental;
using EOD.Model.Fundamental;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class FundamentalDataAPI : BaseAPI, IFundamentalDataAPI
	{
		private const string sourceFundamental = @"https://eodhistoricaldata.com/api/fundamentals/{0}?";

		public FundamentalDataAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

		public Task<FundamentalData> GetFundamentalsDataAsync(string ticker, string filters = null)
		{
			string uri = string.Format(sourceFundamental, ticker);
			if (filters != null) uri += $"&filter={filters}";
			return ExecuteQueryAsync<FundamentalData>(uri);
		}

		private const string bulkFundamental = @"https://eodhistoricaldata.com/api/bulk-fundamentals/{0}?&fmt=json";
		public Task<Dictionary<string, BulkFundamentalData>> GetBulkFundamentalsDataAsync(string ticker, int? offset = null, int? limit = null, string symbols = null)
		{
			string uri = string.Format(bulkFundamental, ticker);
			if (offset != null) uri += $"&offset={offset}";
			if (limit != null) uri += $"&limit={limit}";
			if (symbols != null) uri += $"&symbols={symbols}";
			return ExecuteQueryAsync<Dictionary<string, BulkFundamentalData>>(uri);
		}

		private const string bulkFundamentalExtended = @"https://eodhistoricaldata.com/api/bulk-fundamentals/{0}?&fmt=json&version=1.2";
		public Task<List<BulkFundamentalData>> GetBulkFundamentalsExtendedDataAsync(string ticker, int? offset = null, int? limit = null, string symbols = null)
		{
			string uri = string.Format(bulkFundamentalExtended, ticker);
			if (offset != null) uri += $"&offset={offset}";
			if (limit != null) uri += $"&limit={limit}";
			if (symbols != null) uri += $"&symbols={symbols}";
			return ExecuteQueryAsync<List<BulkFundamentalData>>(uri);
		}
	}
}

using EOD.APIs.Abstract;
using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class EconomicEventDataAPI : BaseAPI, IEconomicEventDataAPI
	{
		private const string source = @"https://eodhistoricaldata.com/api/economic-events?";

		public EconomicEventDataAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

		public Task<List<EconomicEventData>> GetEconomicEventsDataAsync(DateTime? from = null, DateTime? to = null,
			string country = null, string comparison = null, int? offset = null, int? limit = null)
		{
			string uri = source;
			if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
			if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
			if (country != null) uri += $"&country={country}";
			if (comparison != null) uri += $"&comparison={comparison}";
			if (offset != null) uri += $"&offset={offset}";
			if (limit != null) uri += $"&limit={limit}";

			return ExecuteQueryAsync<List<EconomicEventData>>(uri);
		}
	}
}

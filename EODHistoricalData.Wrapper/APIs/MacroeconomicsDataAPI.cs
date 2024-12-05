using EOD.APIs.Abstract;
using EOD.Model;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class MacroIndicatorsAPI : BaseAPI, IMacroIndicatorsAPI
	{
		private const string sourceMacroIndicators = @"https://eodhistoricaldata.com/api/macro-indicator/{0}?&fmt=json&indicator={1}";
		public MacroIndicatorsAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }
		public async Task<List<MacroIndicator>> GetDataAsync(string country, string indicator)
		{
			object[] args = new object[]
			{
				country,
				indicator
			};
			string url = string.Format(sourceMacroIndicators, args);
			return await ExecuteQueryAsync<List<MacroIndicator>>(url);
		}

		private const string sourceMacroeconomicsData = @"https://eodhistoricaldata.com/api/eod/{0}?&fmt=json";
		public async Task<List<MacroeconomicsData>> GetMacroeconomicsDataAsync(string ticker)
		{
			object[] args = new object[]
			{
				ticker
			};
			string url = string.Format(sourceMacroeconomicsData, args);
			return await ExecuteQueryAsync<List<MacroeconomicsData>>(url);
		}
	}
}

using EOD.Model.BondsFundamentalData;

namespace EOD.APIs
{
    internal class BondsFundamentalsAndHistoricalAPI : BaseAPI, IBondsFundamentalsAndHistoricalAPI
    {
        private const string sourceBondsFundamentals = @"https://eodhistoricaldata.com/api/bond-fundamentals/{0}?";

        public BondsFundamentalsAndHistoricalAPI(string apiKey, bool useProxy) : base(apiKey, useProxy) { }

        public async Task<BondsFundamentalData> GetBondsFundamendalDataAsync(string cusip)
        {
            object[] args = new object[]
            {
                cusip
            };
            string uri = string.Format(sourceBondsFundamentals, args);
            return await ExecuteQueryAsync<BondsFundamentalData>(uri);
        }

        private const string sourceBondHistoricalData = @"https://eodhistoricaldata.com/api/eod/{0}?&fmt=json";

        public async Task<List<BondHistoricalData>> GetBondHistoricalDataAsync(string code, DateTime? from = null, DateTime? to = null, string? order = null, string? period = null)
        {
            string uri = sourceBondHistoricalData;
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (period != null) uri += $"&period={period}";

            object[] args = new object[]
            {
                code
            };

            string url = string.Format(uri, args);
            return await ExecuteQueryAsync<List<BondHistoricalData>>(url);
        }
    }
}

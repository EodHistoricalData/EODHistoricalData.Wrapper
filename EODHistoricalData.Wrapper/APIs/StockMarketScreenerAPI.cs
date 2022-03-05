using EOD.Model.Screener;

namespace EOD.APIs
{
    internal class StockMarketScreenerAPI : BaseAPI, IStockMarketScreenerAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/screener?";

        public StockMarketScreenerAPI(string apiKey, System.Net.IWebProxy? proxy, string? source) : base(apiKey, proxy, source) { }
        public Task<StockMarkerScreener> GetStockMarketScreenerAsync(string? filters = null, string? signals = null,
            string? sort = null, int? limit = null, int? offset = null)
        {
            string uri = source;
            if (filters != null) uri += $"&filters={filters}";
            if (signals != null) uri += $"&signals={signals}";
            if (sort != null) uri += $"&sort={sort}";
            if (limit != null) uri += $"&limit={limit}";
            if (offset != null) uri += $"&offset={offset}";

            return ExecuteQueryAsync<StockMarkerScreener>(uri);
        }
    }
}

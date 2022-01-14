﻿namespace EOD.APIs
{
    internal class FundamentalDataAPI : BaseAPI, IFundamentalDataAPI
    {
        private const string sourceFundamental = @"https://eodhistoricaldata.com/api/fundamentals/{0}";

        public FundamentalDataAPI(string apiKey, System.Net.IWebProxy? proxy) : base(apiKey, proxy) { }

        public Task<FundamentalData> GetFundamentalsDataAsync(string ticker, string? filters = null)
        {
            string uri = string.Format(sourceFundamental, ticker);
            if (filters != null) uri += $"&filters={filters}";
            return ExecuteQueryAsync<FundamentalData>(uri);
        }

        private const string bulkFundamental = @"https://eodhistoricaldata.com/api/bulk-fundamentals/{0}?&fmt=json";
        public Task<BulkFundamental> GetBulkFundamentalsDataAsync(string ticker, int? offset = null, int? limit = null, string? symbols = null)
        {
            string uri = string.Format(bulkFundamental, ticker);
            if (offset != null) uri += $"&offset={offset}";
            if (limit != null) uri += $"&limit={limit}";
            if (symbols != null) uri += $"&symbols={symbols}";
            return ExecuteQueryAsync<BulkFundamental>(uri);
        }
    }
}

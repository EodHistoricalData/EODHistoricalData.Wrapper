using EOD.Model.Bulks;

namespace EOD.APIs
{
    internal class BulkAPI : BaseAPI, IBulkAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/eod-bulk-last-day/{0}?&fmt=json";

        public BulkAPI(string apiKey, bool useProxy) : base(apiKey, useProxy) { }

        public async Task<List<Bulk>> GetBulksAsync(string code, string? type, DateTime? date, string? symbols)
        {
            string uri = source;
            if (type != null) uri += $"&type={type}";
            if (date != null) uri += $"&date={date?.ToString("yyyy-MM-dd")}";
            if (symbols != null) uri += $"&symbols={symbols}";

            object[] args = new object[]
            {
                code,

            };
            string url = string.Format(uri, args);
            return await ExecuteQueryAsync<List<Bulk>>(url);
        }

        public async Task<List<ExtendedBulk>> GetExtendedBulksAsync(string code, string? type, DateTime? date, string? symbols)
        {
            string uri = source;
            uri += "&filter=extended";
            if (type != null) uri += $"&type={type}";
            if (date != null) uri += $"&date={date?.ToString("yyyy-MM-dd")}";
            if (symbols != null) uri += $"&symbols={symbols}";

            object[] args = new object[]
            {
                code,

            };
            string url = string.Format(uri, args);
            return await ExecuteQueryAsync<List<ExtendedBulk>>(url);
        }
    }
}

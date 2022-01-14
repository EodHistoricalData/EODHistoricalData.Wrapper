namespace EOD.APIs
{
    internal class FinancialNewsAPI : BaseAPI, IFinancialNewsAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/news?";

        public FinancialNewsAPI(string apiKey, System.Net.IWebProxy? proxy) : base(apiKey, proxy) { }
        public async Task<List<FinancialNews>> GetFinancialNewsAsync(string? s = null, string? t = null,
            DateTime? from = null, DateTime? to = null, int? limit = null, int? offset = null)
        {
            string uri = source;
            if (s != null) uri += $"&s={s}";
            if (t != null) uri += $"&t={t}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (limit != null) uri += $"&limit={limit}";
            if (offset != null) uri += $"&offset={offset}";

            return await ExecuteQueryAsync<List<FinancialNews>>(uri);
        }
    }
}

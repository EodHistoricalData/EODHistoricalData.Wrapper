namespace EOD.APIs
{
    internal class InsiderTransactionsAPI : BaseAPI, IInsiderTransactionsAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/insider-transactions?";

        public InsiderTransactionsAPI(string apiKey, System.Net.IWebProxy? proxy) : base(apiKey, proxy) { }
        public Task<List<InsiderTransaction>> GetInsiderTransactionsAsync(int? limit = null, DateTime? from = null, DateTime? to = null, string? ticker = null)
        {
            string uri = source;
            if (limit != null) uri += $"&limit={limit}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (ticker != null) uri += $"&code={ticker}";

            return ExecuteQueryAsync<List<InsiderTransaction>>(uri);
        }
    }
}

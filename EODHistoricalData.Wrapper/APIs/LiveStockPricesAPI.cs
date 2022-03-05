namespace EOD.APIs
{
    internal class LiveStockPricesAPI : BaseAPI, ILiveStockPricesAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/real-time/{0}?&fmt=json";
        public LiveStockPricesAPI(string apiKey, System.Net.IWebProxy? proxy, string? source) : base(apiKey, proxy, source) { }
        public async Task<LiveStockPrice> GetLiveStockPricesAsync(string ticker)
        {
            object[] args = new object[]
            {
                ticker
            };
            string uri = string.Format(source, args);
            return await ExecuteQueryAsync<LiveStockPrice>(uri);
        }
    }
}

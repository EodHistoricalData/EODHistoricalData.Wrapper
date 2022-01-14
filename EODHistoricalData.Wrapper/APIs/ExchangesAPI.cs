namespace EOD.APIs
{
    internal class ExchangesAPI : BaseAPI, IExchangesAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/exchanges-list/?&fmt=json";

        public ExchangesAPI(string apiKey, System.Net.IWebProxy? proxy) : base(apiKey, proxy) { }

        public async Task<List<Exchange>> GetExchangeAsync()
        {
            return await ExecuteQueryAsync<List<Exchange>>(source);
        }
    }
}

namespace EOD.APIs
{
    internal class ExchangeSymbolsAPI : BaseAPI, IExchangeSymbolsAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/exchange-symbol-list/{0}?fmt=json";

        public ExchangeSymbolsAPI(string apiKey, bool useProxy) : base(apiKey, useProxy) { }

        public async Task<List<ExchangeSymbol>> GetExchangeSymbolsAsync(string code)
        {
            object[] args = new object[]
            {
                code
            };
            string uri = string.Format(source, args);
            return await ExecuteQueryAsync<List<ExchangeSymbol>>(uri);
        }
    }
}

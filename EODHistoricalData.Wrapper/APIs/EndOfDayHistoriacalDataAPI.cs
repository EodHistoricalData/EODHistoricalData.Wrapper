namespace EOD.APIs
{
    internal class EndOfDayHistoriacalDataAPI : BaseAPI, IEndOfDayHistoricalDataAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/eod/{0}?from={1}&to{2}&period{3}&fmt=json";

        public EndOfDayHistoriacalDataAPI(string apiKey, bool useProxy) : base(apiKey, useProxy) { }

        public async Task<List<HistoricalStockPrice>> GetDataAsync(string tiker, DateTime from, DateTime to, string period)
        {
            object[] args = new object[]
            {
                tiker,
                from.ToString("yyyy-MM-dd"),
                to.ToString("yyyy-MM-dd"),
                period
            };
            string uri = string.Format(source, args);
            return await ExecuteQueryAsync<List<HistoricalStockPrice>>(uri);
        }
    }
}

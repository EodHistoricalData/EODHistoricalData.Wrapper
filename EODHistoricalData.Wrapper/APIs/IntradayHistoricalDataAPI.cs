namespace EOD.APIs
{
    internal class IntradayHistoricalDataAPI : BaseAPI, IIntradayHistoricalDataAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/intraday/{0}?from={1}&to={2}&interval={3}&fmt=json";

        public IntradayHistoricalDataAPI(string apiKey, bool useProxy) : base(apiKey, useProxy) { }


        public async Task<List<IntradayHistoricalStockPrice>> GetDataAsync(string tiker, DateTime from, DateTime to, string interval)
        {
            object[] args = new object[]
            {
                tiker,
                ((DateTimeOffset)from).ToUnixTimeSeconds(),
                ((DateTimeOffset)to).ToUnixTimeSeconds(),
                interval
            };
            string url = string.Format(source, args);
            return await ExecuteQueryAsync<List<IntradayHistoricalStockPrice>>(url);

        }
    }
}

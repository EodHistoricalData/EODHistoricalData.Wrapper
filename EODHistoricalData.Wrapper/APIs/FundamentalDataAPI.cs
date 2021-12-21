namespace EOD.APIs
{
    internal class FundamentalDataAPI : BaseAPI, IFundamentalDataAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/fundamentals/{0}";

        public FundamentalDataAPI(string apiKey, bool useProxy) : base(apiKey, useProxy) { }

        public Task<FundamentalData> GetFundamentalsDataAsync(string tiker)
        {
            string uri = string.Format(source, tiker);
            return ExecuteQueryAsync<FundamentalData>(uri);
        }
    }
}

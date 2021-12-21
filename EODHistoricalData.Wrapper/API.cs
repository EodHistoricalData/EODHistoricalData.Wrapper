namespace EOD
{
    /// <summary>
    /// Provides clients with access to the library functionality. 
    /// </summary>
    public class API
    {
        private readonly IIntradayHistoricalDataAPI intradayHistoricalDataAPI;
        private readonly IEndOfDayHistoricalDataAPI endOfDayHistoricalDataAPI;
        private readonly IFundamentalDataAPI fundamentalDataAPI;
        private readonly ISearchAPI searchAPI;
        private readonly IUserAPI userAPI;

        #region Enums

        /// <summary>
        /// The period of end of day historical data
        /// </summary>
        public enum EndOfDayHistoricalPeriod
        {
            /// <summary>
            /// 1 day
            /// </summary>
            Daily,
            /// <summary>
            /// 1 week
            /// </summary>
            Weekly,
            /// <summary>
            /// 1 month
            /// </summary>
            Monthly
        }

        /// <summary>
        /// The interval of intraday historical data
        /// </summary>
        public enum IntradayHistoricalInterval
        {
            /// <summary>
            /// 1 minute
            /// </summary>
            OneMinute,
            /// <summary>
            /// 5 minutes
            /// </summary>
            FiveMinutes,
            /// <summary>
            /// 1 hour
            /// </summary>
            OneHour
        }

        #endregion

        /// <summary>
        /// Constructor fasade class API.eod
        /// </summary>
        /// <param name="apiKey">your api key</param>
        /// <param name="useProxy">if you use the proxy set true</param>
        public API(string apiKey, bool useProxy = false)
        {
            intradayHistoricalDataAPI = new IntradayHistoricalDataAPI(apiKey, useProxy);
            endOfDayHistoricalDataAPI = new EndOfDayHistoriacalDataAPI(apiKey, useProxy);
            fundamentalDataAPI = new FundamentalDataAPI(apiKey, useProxy);
            searchAPI = new SearchAPI(apiKey, useProxy);
            userAPI = new UserAPI(apiKey, useProxy);
        }

        /// <summary>
        /// Get intraday historical stock price data
        /// </summary>
        /// <param name="tiker">Tiker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.</param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="interval">the possible intervals: ‘5m’ for 5-minutes, ‘1h’ for 1 hour, and ‘1m’ for 1-minute intervals</param>
        /// <returns></returns>
        public async Task<List<IntradayHistoricalStockPrice>> GetIntradayHistoricalStockPriceAsync(string tiker, DateTime from, DateTime to, IntradayHistoricalInterval interval)
        {
            string intervalToString = interval switch
            {
                IntradayHistoricalInterval.OneMinute => "1m",
                IntradayHistoricalInterval.FiveMinutes => "5m",
                IntradayHistoricalInterval.OneHour => "1h",
                _ => "1m",
            };

            return await intradayHistoricalDataAPI.GetDataAsync(tiker, from, to, intervalToString);
        }

        /// <summary>
        /// Get end-of-day historical stock price data 
        /// </summary>
        /// <param name="tiker">Tiker consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. or AAPL.US for NASDAQ.</param>
        /// <param name="from">start search period</param>
        /// <param name="to">end search period</param>
        /// <param name="period">search data interval</param>
        /// <returns></returns>
        public async Task<List<HistoricalStockPrice>> GetEndOfDayHistoricalStockPriceAsync(string tiker, DateTime from, DateTime to, EndOfDayHistoricalPeriod period)
        {
            string periodToString = period switch
            {
                EndOfDayHistoricalPeriod.Daily => "d",
                EndOfDayHistoricalPeriod.Weekly => "w",
                EndOfDayHistoricalPeriod.Monthly => "m",
                _ => "d",
            };

            return await endOfDayHistoricalDataAPI.GetDataAsync(tiker, from, to, periodToString);
        }

        /// <summary>
        /// Get fundamental data feed
        /// </summary>
        /// <param name="tiker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, AAPL.MX for Mexican Stock Exchange. Or AAPL.US for NASDAQ.</param>
        /// <returns></returns>
        public async Task<FundamentalData> GetFundamentalDataAsync(string tiker)
        {
            return await fundamentalDataAPI.GetFundamentalsDataAsync(tiker);
        }

        /// <summary>
        /// Get user data
        /// </summary>
        public async Task<User> GetUserDataAsync()
        {
            return await userAPI.GetUserAsync();
        }

        /// <summary>
        /// Search API for Stocks, ETFs, Mutual Funds, and Indices
        /// </summary>
        /// <param name="searchString">String. REQUIRED. Could be any string with a ticker code or company name. 
        /// Examples: ‘AAPL’, ‘Apple Inc’, ‘Apple’. You can also use ISINs for the search: US0378331005. 
        /// There are no limitations to a minimum number of symbols in the query string</param>
        /// <returns></returns>
        public async Task<List<SearchResult>> GetSearchResultAsync(string searchString)
        {
            return await searchAPI.GetQuerySearchExtendedAsync(searchString);
        }

    }
}

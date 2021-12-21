namespace EOD.APIs.Abstract
{
    /// <summary>
    /// End-Of-Day Historical Stock Market Data API
    /// </summary>
    internal interface IEndOfDayHistoricalDataAPI
    {
        /// <summary>
        /// To get historical stock price data
        /// </summary>
        /// <param name="tiker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, then you can use, for example, MCD.MX for Mexican Stock Exchange. or MCD.US for NYSE</param>
        /// <param name="from">date from</param>
        /// <param name="to">date to</param>
        /// <param name="period">use ‘d’ for daily, ‘w’ for weekly, ‘m’ for monthly prices. By default, daily prices will be shown.</param>
        /// <returns></returns>
        Task<List<HistoricalStockPrice>> GetDataAsync(string tiker, DateTime from, DateTime to, string period);
    }
}

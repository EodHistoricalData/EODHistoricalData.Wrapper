namespace EOD.APIs.Abstract
{
    /// <summary>
    /// Fundamental Data: Stocks, ETFs, Mutual Funds, Indices
    /// </summary>
    internal interface IFundamentalDataAPI
    {
        /// <summary>
        /// To get fundamental data feed
        /// </summary>
        /// <param name="tiker">consists of two parts: {SYMBOL_NAME}.{EXCHANGE_ID}, 
        /// then you can use, for example, AAPL.MX for Mexican Stock Exchange. 
        /// Or AAPL.US for NASDAQ.</param>
        /// <returns></returns>
        Task<FundamentalData> GetFundamentalsDataAsync(string tiker);
    }
}

namespace EOD.APIs.Abstract
{
    /// <summary>
    /// Intraday Historical Data API
    /// </summary>
    internal interface IIntradayHistoricalDataAPI
    {
        Task<List<IntradayHistoricalStockPrice>> GetDataAsync(string ticker, DateTime from, DateTime to, string interval);
    }
}

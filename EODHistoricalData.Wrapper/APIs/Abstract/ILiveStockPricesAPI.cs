using EOD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    /// <summary>
    /// Intraday Historical Data API
    /// </summary>
    internal interface ILiveStockPricesAPI
    {
        Task<LiveStockPrice> GetLiveStockPricesAsync(string ticker);
        Task<List<LiveStockPrice>> GetManyLiveStockPricesAsync(string ticker, List<string> symbols);
    }
}

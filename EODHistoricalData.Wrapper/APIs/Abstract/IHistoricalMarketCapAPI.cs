using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    /// <summary>
    /// Historical Market Capitalization (Marketcap) API
    /// </summary>
    internal interface IHistoricalMarketCapAPI
    {
        Task<List<MarketCapPoint>> GetDataAsync(string ticker, DateTime from, DateTime to);
    }
}

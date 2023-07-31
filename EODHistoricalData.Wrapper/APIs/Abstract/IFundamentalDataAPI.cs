using EOD.Model.BulkFundamental;
using EOD.Model.Fundamental;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        Task<FundamentalData> GetFundamentalsDataAsync(string ticker, string filters = null);

        /// <summary>
        /// Bulk Fundamentals Output
        /// </summary>
        Task<Dictionary<string, BulkFundamentalData>> GetBulkFundamentalsDataAsync(string ticker, int? offset = null,
            int? limit = null, string symbols = null);

        /// <summary>
        /// Bulk Fundamental Extended (ver 1.2)
        /// </summary>
        /// <returns></returns>
        Task<List<BulkFundamentalData>> GetBulkFundamentalsExtendedDataAsync(string ticker, int? offset = null,
            int? limit = null, string symbols = null);
    }
}

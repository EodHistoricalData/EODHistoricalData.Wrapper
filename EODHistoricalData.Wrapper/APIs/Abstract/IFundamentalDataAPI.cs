using EOD.Model.Fundamental;

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
        Task<BulkFundamental> GetBulkFundamentalsDataAsync(string ticker, int? offset = null,
            int? limit = null, string symbols = null);
    }
}

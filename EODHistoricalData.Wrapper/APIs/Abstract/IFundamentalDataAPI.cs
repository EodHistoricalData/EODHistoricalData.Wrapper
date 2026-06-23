using EOD.Model.BulkFundamental;
using EOD.Model.Fundamental;
using Newtonsoft.Json.Linq;
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
        /// To get fundamental data feed deserialized into a caller-supplied type.
        /// Use this when a filter narrows the response below the top level (e.g.
        /// "Financials" or "General"), because the API then returns the inner
        /// object/array/value rather than the full FundamentalData shape.
        /// </summary>
        Task<T> GetFundamentalsDataAsync<T>(string ticker, string filters = null);

        /// <summary>
        /// To get the raw fundamental data feed as a JToken. Handles any filter
        /// shape (object, array or scalar) without mapping to FundamentalData.
        /// </summary>
        Task<JToken> GetFundamentalsDataRawAsync(string ticker, string filters = null);

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

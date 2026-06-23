using EOD.Model;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    /// <summary>
    /// Search API for Stocks, ETFs, Mutual Funds and Indices
    /// </summary>
    internal interface ISearchAPI
    {
        Task<List<SearchExtendedResult>> GetQuerySearchExtendedAsync(string searchString);
        Task<List<SearchResult>> GetQuerySearchAsync(string searchString);

    }
}

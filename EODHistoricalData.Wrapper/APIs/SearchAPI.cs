using EOD.APIs.Abstract;
using EOD.Model;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
    internal class SearchAPI : BaseAPI, ISearchAPI
    {
        private const string sourceQuerySearchExtended = @"https://eodhistoricaldata.com/api/query-search-extended/?q={0}";
        public SearchAPI(string apiToken, System.Net.IWebProxy proxy, string source) : base(apiToken, proxy, source) { }
        public async Task<List<SearchResult>> GetQuerySearchExtendedAsync(string searchString)
        {
            string uri = string.Format(sourceQuerySearchExtended, searchString);
            return await ExecuteQueryAsync<List<SearchResult>>(uri);
        }

    }
}

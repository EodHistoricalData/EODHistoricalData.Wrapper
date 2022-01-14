namespace EOD.APIs
{
    internal class SearchAPI : BaseAPI, ISearchAPI
    {
        private const string sourceQuerySearchExtended = @"https://eodhistoricaldata.com/api/query-search-extended/?q={0}";
        public SearchAPI(string apiToken, bool useProxy) : base(apiToken, useProxy) { }
        public async Task<List<SearchResult>> GetQuerySearchExtendedAsync(string searchString)
        {
            string uri = string.Format(sourceQuerySearchExtended, searchString);
            return await ExecuteQueryAsync<List<SearchResult>>(uri);
        }

    }
}

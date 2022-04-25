using EOD.APIs.Abstract;
using EOD.Model;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
    internal class ExchangesAPI : BaseAPI, IExchangesAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/exchanges-list/?&fmt=json";

        public ExchangesAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

        public async Task<List<Exchange>> GetExchangeAsync()
        {
            return await ExecuteQueryAsync<List<Exchange>>(source);
        }
    }
}

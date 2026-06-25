using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EOD.APIs.Abstract;
using EOD.Model;

namespace EOD.APIs
{
    internal class HistoricalMarketCapAPI : BaseAPI, IHistoricalMarketCapAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/historical-market-cap/{0}?from={1}&to={2}&fmt=json";

        public HistoricalMarketCapAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

        public async Task<List<MarketCapPoint>> GetDataAsync(string ticker, DateTime from, DateTime to)
        {
            object[] args = new object[]
            {
                ticker,
                from.ToString("yyyy-MM-dd"),
                to.ToString("yyyy-MM-dd"),
            };
            string uri = string.Format(source, args);
            var response = await ExecuteQueryAsync<Dictionary<string, MarketCapPoint>>(uri);
            return response.Values.ToList();
        }
    }
}
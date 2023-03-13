using EOD.APIs.Abstract;
using EOD.Model;
using EOD.Model.OptionsData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EOD.APIs
{
    internal class SentimentsApi : BaseAPI, ISentimentsAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/sentiments?s={0}";
        public SentimentsApi(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }
        public Task<Dictionary<string, List<SentimentsData>>> GetSentimentsAsync(List<string> symbols, DateTime? from = null, DateTime? to = null, bool? tweets = null)
        {
            string symbolsString = string.Join(",", symbols);
            string uri = source;
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (tweets != null) uri = AddTweets(uri);

            object[] args = new object[]
            {
                symbolsString
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<Dictionary<string, List<SentimentsData>>>(url);
        }

        private string AddTweets(string uri)
        {
            return uri.Insert(uri.LastIndexOf('/') + 1, "tweets-");
        }
    }
}

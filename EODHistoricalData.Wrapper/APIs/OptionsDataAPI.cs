using EOD.Model.OptionsData;

namespace EOD.APIs
{
    internal class OptionsDataAPI : BaseAPI, IOptionalDataAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/options/{0}?";
        public OptionsDataAPI(string apiKey, System.Net.IWebProxy? proxy, string? source) : base(apiKey, proxy, source) { }
        public Task<OptionsData> GetOptionsDataAsync(string ticker, DateTime? from = null, DateTime? to = null, DateTime? trade_date_from = null, DateTime? trade_date_to = null, string? contract_name = null)
        {
            string uri = source;
            if (from != null) uri += $"from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"to={to?.ToString("yyyy-MM-dd")}";
            if (trade_date_from != null) uri += $"trade_date_from={trade_date_from?.ToString("yyyy-MM-dd")}";
            if (trade_date_to != null) uri += $"trade_date_to={trade_date_to?.ToString("yyyy-MM-dd")}";
            if (contract_name != null) uri += $"contract_name={contract_name}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<OptionsData>(url);
        }
    }
}

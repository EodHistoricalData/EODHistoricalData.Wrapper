using EOD.Model.EarningTrends;
using EOD.Model.IPOs;
using EOD.Model.UpcomingEarnings;
using EOD.Model.UpcomingSplits;

namespace EOD.APIs
{
    internal class CalendarAPI : BaseAPI, ICalendarAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/calendar/";

        public CalendarAPI(string apiKey, System.Net.IWebProxy? proxy) : base(apiKey, proxy) { }
        public Task<UpcomingEarning> GetUpcomingEarningsAsync(DateTime? from = null, DateTime? to = null, string? ticker = null)
        {
            string uri = source;
            uri += "earnings?&fmt=json";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (ticker != null) uri += $"&symbols={ticker}";

            return ExecuteQueryAsync<UpcomingEarning>(uri);
        }
        public Task<EarningTrend> GetEarningTrendsAsync(string ticker)
        {
            string uri = source;
            uri += "trends?&fmt=json&symbols={0}";
            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<EarningTrend>(url);
        }
        public Task<UpcomingIPO> GetUpcomingIPOsAsync(DateTime? from = null, DateTime? to = null)
        {
            string uri = source;
            uri += "ipos?&fmt=json";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";

            return ExecuteQueryAsync<UpcomingIPO>(uri);
        }
        public Task<UpcomingSplit> GetUpcomingSplitsAsync(DateTime? from = null, DateTime? to = null)
        {
            string uri = source;
            uri += "splits?&fmt=json";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";

            return ExecuteQueryAsync<UpcomingSplit>(uri);
        }
    }
}


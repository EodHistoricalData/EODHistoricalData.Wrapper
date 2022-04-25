using EOD.Model.EarningTrends;
using EOD.Model.IPOs;
using EOD.Model.UpcomingEarnings;
using EOD.Model.UpcomingSplits;

using System;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    internal interface ICalendarAPI
    {
        Task<UpcomingEarning> GetUpcomingEarningsAsync(DateTime? from, DateTime? to, string ticker);
        Task<EarningTrend> GetEarningTrendsAsync(string ticker);
        Task<UpcomingIPO> GetUpcomingIPOsAsync(DateTime? from = null, DateTime? to = null);
        Task<UpcomingSplit> GetUpcomingSplitsAsync(DateTime? from = null, DateTime? to = null);
    }
}

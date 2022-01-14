using EOD.Model.TechnicalIndicators;

using static EOD.API;

namespace EOD.APIs
{
    internal class TechnicalIndicatorAPI : BaseAPI, ITechnicalIndicatorAPI
    {
        private const string source = @"https://eodhistoricaldata.com/api/technical/{0}?&fmt=json";

        public TechnicalIndicatorAPI(string apiKey, bool useProxy) : base(apiKey, useProxy) { }
        public Task<List<SMA>> GetSMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, string? order = null, int? splitAdjustedOnly = null)
        {
            string uri = source;
            uri += $"&function=sma";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (splitAdjustedOnly != null) uri += $"&splitadjusted_only={splitAdjustedOnly}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<SMA>>(url);
        }
        public Task<List<EMA>> GetEMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, string? order = null, int? splitAdjustedOnly = null)
        {
            string uri = source;
            uri += $"&function=ema";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (splitAdjustedOnly != null) uri += $"&splitadjusted_only={splitAdjustedOnly}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<EMA>>(url);
        }
        public Task<List<WMA>> GetWMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, string? order = null, int? splitAdjustedOnly = null)
        {
            string uri = source;
            uri += $"&function=wma";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (splitAdjustedOnly != null) uri += $"&splitadjusted_only={splitAdjustedOnly}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<WMA>>(url);
        }
        public Task<List<SplitAdjustedData>> GetSplitAdjustedDataAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null, HistoricalPeriod? historicalPeriod = null)
        {
            string uri = source;
            uri += $"&function=splitadjusted";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (historicalPeriod != null) uri += $"&agg_period={historicalPeriod}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<SplitAdjustedData>>(url);
        }
        public Task<List<AverageVolume>> GetAverageVolumeAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, string? order = null)
        {
            string uri = source;
            uri += $"&function=avgvol";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<AverageVolume>>(url);
        }
        public Task<List<AverageVolumebyPrice>> GetAverageVolumebyPriceAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null)
        {
            string uri = source;
            uri += $"&function=avgvolccy";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<AverageVolumebyPrice>>(url);
        }
        public Task<List<Volatility>> GetVolatilityAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null, int? splitAdjustedOnly = null)
        {
            string uri = source;
            uri += $"&function=volatility";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (splitAdjustedOnly != null) uri += $"&splitadjusted_only={splitAdjustedOnly}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<Volatility>>(url);
        }
        public Task<List<Stochastic>> GetStochasticAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null, int? fast_kperiod = null, int? slow_kperiod = null, int? slow_dperiod = null)
        {
            string uri = source;
            uri += $"&function=stochastic";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (fast_kperiod != null) uri += $"&fast_kperiod={fast_kperiod}";
            if (slow_kperiod != null) uri += $"&slow_kperiod={slow_kperiod}";
            if (slow_dperiod != null) uri += $"&slow_dperiod={slow_dperiod}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<Stochastic>>(url);
        }
        public Task<List<RelativeStrengthIndex>> GetRelativeStrengthIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null, int? splitAdjustedOnly = null)
        {
            string uri = source;
            uri += $"&function=rsi";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (splitAdjustedOnly != null) uri += $"&splitadjusted_only={splitAdjustedOnly}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<RelativeStrengthIndex>>(url);
        }
        public Task<List<StandardDeviation>> GetStandardDeviationAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null)
        {
            string uri = source;
            uri += $"&function=stddev";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<StandardDeviation>>(url);
        }
        public Task<List<StochasticRelativeStrengthIndex>> GetStochasticRelativeStrengthIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null, int? fast_kperiod = null, int? fast_dperiod = null)
        {
            string uri = source;
            uri += $"&function=stochrsi";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (fast_kperiod != null) uri += $"&fast_kperiod={fast_kperiod}";
            if (fast_dperiod != null) uri += $"&fast_dperiod={fast_dperiod}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<StochasticRelativeStrengthIndex>>(url);
        }
        public Task<List<Slope>> GetSlopeAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null, int? splitAdjustedOnly = null)
        {
            string uri = source;
            uri += $"&function=slope";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (splitAdjustedOnly != null) uri += $"&splitadjusted_only={splitAdjustedOnly}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<Slope>>(url);
        }
        public Task<List<DirectionalMovementIndex>> GetDirectionalMovementIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null)
        {
            string uri = source;
            uri += $"&function=dmi";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<DirectionalMovementIndex>>(url);
        }
        public Task<List<AverageDirectionalMovementIndex>> GetAverageDirectionalMovementIndexAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, string? order = null)
        {
            string uri = source;
            uri += $"&function=adx";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<AverageDirectionalMovementIndex>>(url);
        }
        public Task<List<MovingAverageConvergence>> GetMovingAverageConvergenceAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
            string? order = null, int? splitAdjustedOnly = null, int? fast_period = null, int? slow_period = null, int? signal_period = null)
        {
            string uri = source;
            uri += $"&function=macd";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (splitAdjustedOnly != null) uri += $"&splitadjusted_only={splitAdjustedOnly}";
            if (fast_period != null) uri += $"&fast_period={fast_period}";
            if (slow_period != null) uri += $"&slow_period={slow_period}";
            if (signal_period != null) uri += $"&signal_period={signal_period}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<MovingAverageConvergence>>(url);
        }
        public Task<List<AverageTrueRange>> GetAverageTrueRangeAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, string? order = null)
        {
            string uri = source;
            uri += $"&function=atr";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<AverageTrueRange>>(url);
        }
        public Task<List<CommodityChannelIndex>> GetCommodityChannelIndexAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, string? order = null)
        {
            string uri = source;
            uri += $"&function=cci";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<CommodityChannelIndex>>(url);
        }
        public Task<List<ParabolicSAR>> GetParabolicSARAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, string? order = null, double? acceleration = null, double? maximum = null)
        {
            string uri = source;
            uri += $"&function=sar";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";
            if (acceleration != null) uri += $"&acceleration={acceleration}";
            if (maximum != null) uri += $"&maximum={maximum}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<ParabolicSAR>>(url);
        }
        public Task<List<AmiBrokerData>> GetAmiBrokerDataAsync(string ticker, int? period = null, DateTime? from = null,
            DateTime? to = null, string? order = null)
        {
            string uri = source;
            uri += $"&function=format_amibroker";
            if (period != null) uri += $"&period={period}";
            if (from != null) uri += $"&from={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&to={to?.ToString("yyyy-MM-dd")}";
            if (order != null) uri += $"&order={order}";

            object[] args = new object[]
            {
                ticker
            };
            string url = string.Format(uri, args);
            return ExecuteQueryAsync<List<AmiBrokerData>>(url);
        }
    }
}

using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class GrowthRateData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none0")]
        public double? LongTermProjectedEarningsGrowth
        {
            get
            {
                if (double.TryParse(_LongTermProjectedEarningsGrowth, out double result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            set { }
        }

        [JsonProperty("Long-Term Projected Earnings Growth")]
        private string _LongTermProjectedEarningsGrowth { set; get; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none1")]
        public double? HistoricalEarningsGrowth
        {
            get
            {
                if (double.TryParse(_HistoricalEarningsGrowth, out double result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            set { }
        }

        [JsonProperty("Historical Earnings Growth")]
        private string _HistoricalEarningsGrowth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none2")]
        public double? SalesGrowth
        {
            get
            {
                if (double.TryParse(_SalesGrowth, out double result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            set { }
        }

        [JsonProperty("Sales Growth")]
        private string _SalesGrowth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none3")]
        public double? CashFlowGrowth
        {
            get
            {
                if (double.TryParse(_CashFlowGrowth, out double result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            set { }
        }

        [JsonProperty("Cash-Flow Growth")]
        private string _CashFlowGrowth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none4")]
        public double? BookValueGrowth
        {
            get
            {
                if (double.TryParse(_BookValueGrowth, out double result))
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            set { }
        }

        [JsonProperty("Book-Value Growth")]
        private string _BookValueGrowth { get; set; }
    }
}

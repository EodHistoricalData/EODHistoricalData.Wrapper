using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class ValuationsRatesData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none0")]
        public double? PriceProspectiveEarnings
        {
            get
            {
                if (double.TryParse(_PriceProspectiveEarnings, out var result))
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

        [JsonProperty("Price/Prospective Earnings")]
        private string _PriceProspectiveEarnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none1")]
        public double? PriceBook
        {
            get
            {
                if (double.TryParse(_PriceBook, out var result))
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

        [JsonProperty("Price/Book")]
        private string _PriceBook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none2")]
        public double? PriceSales
        {
            get
            {
                if (double.TryParse(_PriceSales, out var result))
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

        [JsonProperty("Price/Sales")]
        private string _PriceSales { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none3")]
        public double? PriceCashFlow
        {
            get
            {
                if (double.TryParse(_PriceCashFlow, out var result))
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

        [JsonProperty("Price/Cash Flow")]
        private string _PriceCashFlow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none4")]
        public double? DividendYieldFactor
        {
            get
            {
                if (double.TryParse(_DividendYieldFactor, out var result))
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
        [JsonProperty("Dividend-Yield Factor")]
        private string _DividendYieldFactor { get; set; }
    }
}

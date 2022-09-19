using EOD.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class SplitsDividends
    {
        /// <summary>
        /// 
        /// </summary>
        public double? ForwardAnnualDividendRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ForwardAnnualDividendYield { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PayoutRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DividendDate")]
        private string DividendDateJSON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none0")]
        public DateTime? DividendDate
        {
            get => GetDate.ParseDate(DividendDateJSON);
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExDividendDate")]
        private string ExDividendDateJSON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none1")]
        public DateTime? ExDividendDate
        {
            get => GetDate.ParseDate(ExDividendDateJSON);
        }
        /// <summary>
        /// 
        /// </summary>
        public string LastSplitFactor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LastSplitDate")]
        private string LastSplitDateJSON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none2")]
        public DateTime? LastSplitDate { get => GetDate.ParseDate(LastSplitDateJSON); }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, NumberDividendsByYear> NumberDividendsByYear { get; set; }
    }
}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EOD.Model.OptionsData
{
    /// <summary>
    /// 
    /// </summary>
    public class OptionsData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("exchange")]
        public string Exchange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastTradeDate")]
        public DateTime? LastTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lastTradePrice")]
        public double? LastTradePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public List<Data> Data { get; set; }
    }
}

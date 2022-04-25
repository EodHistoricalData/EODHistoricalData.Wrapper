using System.Collections.Generic;

namespace EOD.Model.ExchangeDetails
{
    /// <summary>
    /// 
    /// </summary>
    public class ExchangeDetail
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OperatingMIC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Timezone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, ExchangeHolidays> ExchangeHolidays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsOpen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TradingHours TradingHours { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? ActiveTickers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? PreviousDayUpdatedTickers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? UpdatedTickers { get; set; }
    }
}


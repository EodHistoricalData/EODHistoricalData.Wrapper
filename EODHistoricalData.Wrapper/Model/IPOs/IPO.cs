using System;

namespace EOD.Model.IPOs
{
    /// <summary>
    /// 
    /// </summary>
    public class IPO
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Exchange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FillingDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? AmendedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PriceFrom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PriceTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? OfferPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Shares { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? DealType { get; set; }
    }
}

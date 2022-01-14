namespace EOD.Model.BondsFundamentalData
{
    /// <summary>
    /// 
    /// </summary>
    public class IssueData
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? IssueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? OfferingDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FirstCouponDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FirstTradingDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? CouponPaymentFrequency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Issuer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? IssuerDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? IssuerCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? IssuerURL { get; set; }
    }
}

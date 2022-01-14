namespace EOD.Model.OptionsData
{
    /// <summary>
    /// 
    /// </summary>
    public class ContractData
    {
        /// <summary>
        /// 
        /// </summary>
        public string? ContractName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? ContractSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? ContractPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? InTheMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? LastTradeDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExpirationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Strike { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? LastPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Bid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Ask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ChangePercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? OpenInterest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ImpliedVolatility { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Delta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Gamma { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Theta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Vega { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Rho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Theoretical { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? IntrinsicValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TimeValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public uint? DaysBeforeExpiration { get; set; }
    }
}

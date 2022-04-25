using System;
using System.Collections.Generic;

namespace EOD.Model.OptionsData
{
    /// <summary>
    /// 
    /// </summary>
    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExpirationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ImpliedVolatility { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? PutVolume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? CallVolume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PutCallVolumeRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? PutOpenInterest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? CallOpenInterest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PutCallOpenInterestRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? OptionsCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, List<ContractData>> Options { get; set; }
    }
}
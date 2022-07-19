using System;

namespace EOD.Model.BulkFundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class General
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }
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
        public string CurrencyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CurrencyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CountryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CountryISO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ISIN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CUSIP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sector { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? FullTimeEmployees { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}

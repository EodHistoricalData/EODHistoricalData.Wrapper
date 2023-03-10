using EOD.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EOD.Model.Fundamental
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
        public string LEI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PrimaryTicker { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CUSIP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CIK { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EmployerIdNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FiscalYearEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IPODate")]
        private string IPODateJSON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none0")]
        public DateTime? IPODate
        {
            get => GetDate.ParseDate(IPODateJSON);
        }
        /// <summary>
        /// 
        /// </summary>
        public string InternationalDomestic { get; set; }
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
        public string GicSector { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GicGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GicIndustry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GicSubIndustry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HomeCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsDelisted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AddressData AddressData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, Listing> Listings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, Officer> Officers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WebURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LogoURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? FullTimeEmployees { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UpdatedAt")]
        private string UpdatedAtJSON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none1")]
        public DateTime? UpdatedAt
        {
            get => GetDate.ParseDate(UpdatedAtJSON);
        }
        /// <summary>
        /// 
        /// </summary>
        public string Fund_Summary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fund_Family { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fund_Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fund_Style { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fiscal_Year_End { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? MarketCapitalization { get; set; }
        /// <summary>
        /// for Crypto
        /// </summary>
        public string Category { get; set; }
    }
}

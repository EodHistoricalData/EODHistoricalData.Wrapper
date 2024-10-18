using Newtonsoft.Json;
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
		/// Extended
		/// </summary>
		public string LEI { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string PrimaryTicker { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string CUSIP { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string CIK { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string EmployerIdNumber { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string FiscalYearEnd { get; set; }
		/// <summary>
		/// extended secondary (use DateTime IPODate)
		/// </summary>
		[JsonProperty("IPODate")]
		private string IPODateString { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		[JsonProperty("NO_PROPERTY")]
		public DateTime? IPODate
		{
			get
			{
				try
				{
					return DateTime.ParseExact(IPODateString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
				}
				catch
				{
					return null;
				}
			}
		}
		/// <summary>
		/// Extended
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
		/// Extended
		/// </summary>
		public string GicSector { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string GicGroup { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string GicIndustry { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string GicSubIndustry { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string HomeCategory { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public bool IsDelisted { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string Address { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string Phone { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string WebURL { get; set; }
		/// <summary>
		/// Extended
		/// </summary>
		public string LogoURL { get; set; }
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

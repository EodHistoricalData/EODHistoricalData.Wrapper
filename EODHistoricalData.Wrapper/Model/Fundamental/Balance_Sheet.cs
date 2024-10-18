using System.Collections.Generic;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// Balance Sheet
	/// </summary>
	public class Balance_Sheet
	{
		/// <summary>
		/// Currency_symbol
		/// </summary>
		public string Currency_symbol { get; set; }
		/// <summary>
		/// Quarterly
		/// </summary>
		public Dictionary<string, Balance_SheetData> Quarterly { get; set; }
		/// <summary>
		/// Yearly
		/// </summary>
		public Dictionary<string, Balance_SheetData> Yearly { get; set; }
		/// <summary>
		/// For bulk
		/// </summary>
		public Balance_SheetData Quarterly_last_0 { get; set; }
		/// <summary>
		/// For bulk
		/// </summary>
		public Balance_SheetData Quarterly_last_1 { get; set; }
		/// <summary>
		/// For bulk
		/// </summary>
		public Balance_SheetData Quarterly_last_2 { get; set; }
		/// <summary>
		/// For bulk
		/// </summary>
		public Balance_SheetData Quarterly_last_3 { get; set; }
		/// <summary>
		/// For bulk
		/// </summary>
		public Balance_SheetData Yearly_last_0 { get; set; }
		/// <summary>
		/// For bulk
		/// </summary>
		public Balance_SheetData Yearly_last_1 { get; set; }
		/// <summary>
		/// For bulk
		/// </summary>
		public Balance_SheetData Yearly_last_2 { get; set; }
		/// <summary>
		/// For bulk
		/// </summary>
		public Balance_SheetData Yearly_last_3 { get; set; }


	}
}

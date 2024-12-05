namespace EOD.Model.Bulks
{
	/// <summary>
	/// 
	/// </summary>
	public class Bulk
	{
		/// <summary>
		/// eod, splits, dividends
		/// </summary>
		public string Code { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Exchange_Short_Name { get; set; }
		/// <summary>
		/// eod, splits, dividends
		/// </summary>
		public string Date { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Open { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string High { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Low { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Close { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Adjusted_Close { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Volume { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Prev_Close { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Change { get; set; }
		/// <summary>
		/// eod
		/// </summary>
		public string Change_p { get; set; }

		/// <summary>
		/// splist, dividends
		/// </summary>
		public string Exchange { get; set; }
		/// <summary>
		/// splist
		/// </summary>
		public string Split { get; set; }

		/// <summary>
		/// dividends
		/// </summary>
		public string Dividend { get; set; }
		/// <summary>
		/// dividends
		/// </summary>
		public string Currency { get; set; }
		/// <summary>
		/// dividends
		/// </summary>
		public string DeclarationDate { get; set; }
		/// <summary>
		/// dividends
		/// </summary>
		public string RecordDate { get; set; }
		/// <summary>
		/// dividends
		/// </summary>
		public string PaymentDate { get; set; }
		/// <summary>
		/// dividends
		/// </summary>
		public string Period { get; set; }
		/// <summary>
		/// dividends
		/// </summary>
		public string UnadjustedValue { get; set; }
	}
}

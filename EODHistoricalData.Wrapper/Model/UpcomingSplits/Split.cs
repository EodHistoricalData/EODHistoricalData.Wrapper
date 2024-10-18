using System;

namespace EOD.Model.UpcomingSplits
{
	/// <summary>
	/// 
	/// </summary>
	public class Split
	{
		/// <summary>
		/// 
		/// </summary>
		public string Code { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Split_Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Optionable { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public long? Old_Shares { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int? New_Shares { get; set; }
	}
}

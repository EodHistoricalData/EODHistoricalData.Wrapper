using System;

namespace EOD.Model.BondsFundamentalData
{
	/// <summary>
	/// 
	/// </summary>
	public class Rating
	{
		/// <summary>
		/// 
		/// </summary>
		public string MoodyRating { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MoodyRatingUpdateDate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string SPRating { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SPRatingUpdateDate { get; set; }
	}
}

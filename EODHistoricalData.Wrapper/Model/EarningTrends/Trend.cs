using System;

namespace EOD.Model.EarningTrends
{
	/// <summary>
	/// 
	/// </summary>
	public class Trend
	{
		/// <summary>
		/// 
		/// </summary>
		public string Code { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Date { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Growth { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EarningsEstimateAvg { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EarningsEstimateLow { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EarningsEstimateHigh { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EarningsEstimateYearAgoEps { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EarningsEstimateNumberOfAnalysts { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EarningsEstimateGrowth { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? RevenueEstimateAvg { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? RevenueEstimateLow { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? RevenueEstimateHigh { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? RevenueEstimateYearAgoEps { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? RevenueEstimateNumberOfAnalysts { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? RevenueEstimateGrowth { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsTrendCurrent { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsTrend7daysAgo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsTrend30daysAgo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsTrend60daysAgo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsTrend90daysAgo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsRevisionsUpLast7days { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsRevisionsUpLast30days { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsRevisionsDownLast7days { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EpsRevisionsDownLast30days { get; set; }
	}
}

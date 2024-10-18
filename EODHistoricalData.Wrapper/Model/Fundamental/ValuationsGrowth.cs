namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class ValuationsGrowth
	{
		/// <summary>
		/// 
		/// </summary>
		public ValuationsRatesData Valuations_Rates_Portfolio { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public ValuationsRatesData Valuations_Rates_To_Category { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public GrowthRateData Growth_Rates_Portfolio { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public GrowthRateData Growth_Rates_To_Category { get; set; }
	}
}

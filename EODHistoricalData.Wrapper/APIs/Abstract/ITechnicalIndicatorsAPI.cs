using EOD.Model.TechnicalIndicators;
using EODHistoricalData.Wrapper.Model.TechnicalIndicators;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using static EOD.API;

namespace EOD.APIs.Abstract
{
	internal interface ITechnicalIndicatorAPI
	{
		/// <summary>
		/// This function returns the Simple Moving Average indicator
		/// </summary>
		Task<List<SMA>> GetSMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, string order = null, int? splitAdjustedOnly = null);

		/// <summary>
		/// This function returns the Exponential Moving Average indicator
		/// </summary>
		Task<List<EMA>> GetEMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, string order = null, int? splitAdjustedOnly = null);

		/// <summary>
		/// This function returns the Weighted Moving Average indicator
		/// </summary>
		Task<List<WMA>> GetWMAAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null, string order = null, int? splitAdjustedOnly = null);

		/// <summary>
		/// It’s not a technical indicator itself, but we added this function to our API.
		/// By default Open, High, Low and Close values (OHLC) provided in raw values and adjust neither for splits nor for dividends.
		/// </summary>
		Task<List<SplitAdjustedData>> GetSplitAdjustedDataAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null, HistoricalPeriod? historicalPeriod = null);


		/// <summary>
		/// This function returns the Average Trading Volume.
		/// </summary>
		Task<List<AverageVolume>> GetAverageVolumeAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null);

		/// <summary>
		/// This function returns the Average Trading Volume.
		/// </summary>
		Task<List<AverageVolumebyPrice>> GetAverageVolumebyPriceAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null);

		/// <summary>
		/// This function returns the Volatility, a statistical measure of the dispersion of returns for a given security or market index.
		/// </summary>
		Task<List<Volatility>> GetVolatilityAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null, int? splitAdjustedOnly = null);

		/// <summary>
		/// This function returns the Volatility, a statistical measure of the dispersion of returns for a given security or market index.
		/// </summary>
		Task<List<Stochastic>> GetStochasticAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null, int? fast_kperiod = null, int? slow_kperiod = null, int? slow_dperiod = null);

		/// <summary>
		/// This function returns the Relative Strength Index (RSI) technical indicator.
		/// </summary>
		Task<List<RelativeStrengthIndex>> GetRelativeStrengthIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null, int? splitAdjustedOnly = null);

		/// <summary>
		/// This function returns the Standard Deviation (stddev) technical indicator.
		/// </summary>
		Task<List<StandardDeviation>> GetStandardDeviationAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null);

		/// <summary>
		/// This function returns Stochastic Relative Strength Index values.
		/// </summary>
		Task<List<StochasticRelativeStrengthIndex>> GetStochasticRelativeStrengthIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null, int? fast_kperiod = null, int? fast_dperiod = null);

		/// <summary>
		/// This function returns the Linear Regression Slope.
		/// </summary>
		Task<List<Slope>> GetSlopeAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null, int? splitAdjustedOnly = null);

		/// <summary>
		/// This function returns the Directional Movement Index.
		/// </summary>
		Task<List<DirectionalMovementIndex>> GetDirectionalMovementIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null);

		/// <summary>
		/// This function returns the Average Directional Movement Index.
		/// </summary>
		Task<List<AverageDirectionalMovementIndex>> GetAverageDirectionalMovementIndexAsync(string ticker, int? period = null, DateTime? from = null,
			DateTime? to = null, string order = null);

		/// <summary>
		/// This function returns Moving Average Convergence/Divergence values.
		/// </summary>
		Task<List<MovingAverageConvergence>> GetMovingAverageConvergenceAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null, int? splitAdjustedOnly = null, int? fast_period = null, int? slow_period = null, int? signal_period = null);

		/// <summary>
		/// This function returns the average of true ranges over the specified period.
		/// </summary>
		Task<List<AverageTrueRange>> GetAverageTrueRangeAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null);

		/// <summary>
		/// This function returns the CCI data. The Commodity Channel Index​ (CCI) is a momentum-based oscillator used to help determine when
		/// an investment vehicle is reaching a condition of being overbought or oversold.
		/// </summary>
		Task<List<CommodityChannelIndex>> GetCommodityChannelIndexAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null);

		/// <summary>
		/// This function returns the Parabolic SAR values.
		/// </summary>
		Task<List<ParabolicSAR>> GetParabolicSARAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null, double? acceleration = null, double? maximum = null);

		/// <summary>
		/// This file format returns the data in AmiBroker File format to import the data into AmiBroker software.
		/// </summary>
		Task<List<AmiBrokerData>> GetAmiBrokerDataAsync(string ticker, int? period = null, DateTime? from = null, DateTime? to = null,
			string order = null);

		/// <summary>
		/// This function returns the Bollinger Bands technical indicator. A type of statistical chart characterizing the prices and volatility over time of a financial instrument, using a formulaic method propounded by John Bollinger in the 1980s.
		/// </summary>
		Task<List<BollingerBands>> GetBollingerBandsAsync(string ticker, int? period = null, DateTime? from = null,
			DateTime? to = null, string order = null);

		Task<List<TechnicalIndicator>> GetTechnicalIndicatorsAsync(string ticker, DateTime? from = null, DateTime? to = null, string order = null,
			List<IndicatorParameters> parameters = null);
	}
}

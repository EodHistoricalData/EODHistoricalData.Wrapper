using Newtonsoft.Json;
using System;

namespace EODHistoricalData.Wrapper.Model.TechnicalIndicators
{
    /// <summary>
    /// 
    /// </summary>
    public class TechnicalIndicator
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Split Adjusted Data
        /// </summary>
        public double? Open { get; set; }
        /// <summary>
        /// Split Adjusted Data
        /// </summary>
        public double? High { get; set; }
        /// <summary>
        /// Split Adjusted Data
        /// </summary>
        public double? Low { get; set; }
        /// <summary>
        /// Split Adjusted Data
        /// </summary>
        public double? Close { get; set; }
        /// <summary>
        /// Split Adjusted Data
        /// </summary>
        public long? Volume { get; set; }
        /// <summary>
        /// Average Volume
        /// </summary>
        public long? Avgvol { get; set; }
        /// <summary>
        /// Average Volume by Price
        /// </summary>
        public double? Avgvolccy { get; set; }
        /// <summary>
        /// SMA
        /// </summary>
        public double? Sma { get; set; }
        /// <summary>
        /// EMA
        /// </summary>
        public double? Ema { get; set; }
        /// <summary>
        /// WMA
        /// </summary>
        public double? Wma { get; set; }
        /// <summary>
        /// Volatility (Variance between returns)
        /// </summary>
        public double? Volatility { get; set; }
        /// <summary>
        /// Stochastic oscillator value (fast)
        /// </summary>
        public double? K_values { get; set; }
        /// <summary>
        /// Stochastic oscillator value (slow)
        /// </summary>
        public double? D_values { get; set; }
        /// <summary>
        /// Relative strength index
        /// </summary>
        public double? Rsi { get; set; }
        /// <summary>
        /// Standard deviation
        /// </summary>
        [JsonProperty("stddev")]
        private object Raw_stddev { get; set; }

        /// <summary>
        /// Standard deviation
        /// </summary>
        [JsonIgnore]
        public double? Stddev
        {
            get
            {
                if (Raw_stddev is double @double) return @double;
                return null;
            }
            set
            {

            }
        }
        /// <summary>
        /// Stochastic Relative Strength Index
        /// </summary>
        public double? Fastkline { get; set; }
        /// <summary>
        /// Stochastic Relative Strength Index
        /// </summary>
        public double? Fastdline { get; set; }
        /// <summary>
        /// Slope (Linear Regression)
        /// </summary>
        public double? Slope { get; set; }
        /// <summary>
        /// Directional Movement Index
        /// </summary>
        public double? Dmi { get; set; }
        /// <summary>
        /// Average Directional Movement Index
        /// </summary>
        public double? Adx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Macd { get; set; }
        /// <summary>
        /// Moving Average Convergence/Divergence
        /// </summary>
        public double? Signal { get; set; }
        /// <summary>
        /// Moving Average Convergence/Divergence
        /// </summary>
        public double? Divergence { get; set; }
        /// <summary>
        /// Average True Range
        /// </summary>
        public double? Atr { get; set; }
        /// <summary>
        /// Commodity Channel Index
        /// </summary>
        public double? Cci { get; set; }
        /// <summary>
        /// Parabolic SAR
        /// </summary>
        public double? Sar { get; set; }
        /// <summary>
        /// Bollinger Bands (upper)
        /// </summary>
        public double? Uband { get; set; }
        /// <summary>
        /// Bollinger Bands (middle)
        /// </summary>
        public double? Mband { get; set; }
        /// <summary>
        /// Bollinger Bands (lower)
        /// </summary>
        public double? Lband { get; set; }
    }
}

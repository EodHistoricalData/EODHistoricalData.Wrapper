using System;
using System.Collections.Generic;
using System.Text;

namespace EODHistoricalData.Wrapper.Model.TechnicalIndicators
{
    /// <summary>
    /// https://eodhd.com/financial-apis/technical-indicators-api/
    /// (e.g., name: function, value: sma)
    /// </summary>
    public class IndicatorParameters
    {
        /// <summary>
        /// function, period etc.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// function : sma, ema etc.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public IndicatorParameters(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}

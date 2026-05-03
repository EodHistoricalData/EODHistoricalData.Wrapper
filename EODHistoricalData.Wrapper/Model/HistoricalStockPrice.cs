using System;

namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HistoricalStockPrice
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Open { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? High { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Adjusted_close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Adjusted_low
        {
            get
            {
                if (_k == null) SetK();

                return Low * _k;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Adjusted_high
        {
            get
            {
                if (_k == null) SetK();

                return High * _k;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Adjusted_open
        {
            get
            {
                if (_k == null) SetK();

                return Open * _k;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public long? Volume { get; set; }

        private decimal? _k;

        private void SetK()
        {
            _k = Adjusted_close / Close;
        }
    }
}

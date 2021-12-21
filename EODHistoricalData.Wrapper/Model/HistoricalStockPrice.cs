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
        public double? Open { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? High { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Adjusted_close { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Adjusted_low
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
        public double? Adjusted_high
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
        public double? Adjusted_open
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

        private double? _k;

        private void SetK()
        {
            _k = Adjusted_close / Close;
        }
    }
}

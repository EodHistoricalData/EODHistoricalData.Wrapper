using Newtonsoft.Json;

namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LiveStockPrice
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? Gmtoffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none0")]
        public long? Timestamp
        {
            get
            {
                return long.TryParse(Timestamp_String, out long result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("Timestamp")]
        private string Timestamp_String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none1")]
        public double? Open
        {
            get
            {
                return double.TryParse(Open_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("Open")]
        private string Open_String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none2")]
        public double? High
        {
            get
            {
                return double.TryParse(High_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("High")]
        private string High_String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none3")]
        public double? Low
        {
            get
            {
                return double.TryParse(Low_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("Low")]
        private string Low_String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none4")]
        public double? Close
        {
            get
            {
                return double.TryParse(Close_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("Close")]
        private string Close_String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none5")]
        public double? Volume
        {
            get
            {
                return double.TryParse(Volume_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("Volume")]
        private string Volume_String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none6")]
        public double? PreviousClose
        {
            get
            {
                return double.TryParse(PreviousClose_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("PreviousClose")]
        private string PreviousClose_String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none7")]
        public double? Change
        {
            get
            {
                return double.TryParse(Change_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("Change")]
        private string Change_String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none8")]
        public double? Change_p
        {
            get
            {
                return double.TryParse(Change_p_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("Change_p")]
        private string Change_p_String { get; set; }
    }
}

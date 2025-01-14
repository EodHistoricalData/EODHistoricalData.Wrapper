using Newtonsoft.Json;
using EODHistoricalData.Wrapper.Utils;

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
                return GetDouble.ParseDouble(Open_String, 0);
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
                return GetDouble.ParseDouble(High_String, 0);
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
                return GetDouble.ParseDouble(Low_String, 0);
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
                return GetDouble.ParseDouble(Close_String, 0);
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
                return GetDouble.ParseDouble(Volume_String, 0);
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
                return GetDouble.ParseDouble(PreviousClose_String, 0);
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
                return GetDouble.ParseDouble(Change_String, 0);
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
                return GetDouble.ParseDouble(Change_p_String, 0);
            }
            set
            {

            }
        }

        [JsonProperty("Change_p")]
        private string Change_p_String { get; set; }
    }
}

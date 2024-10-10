using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class MarketCapitalisationETF
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none0")]
        public double? Mega
        {
            get => double.TryParse(Mega_String, out double result) ? result : 0;
            set { }
        }
        [JsonProperty("Mega")]
        private string Mega_String { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none1")]
        public double? Big
        {
            get => double.TryParse(Big_String, out double result) ? result : 0;
            set { }
        }
        [JsonProperty("Big")]
        private string Big_String { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none2")]
        public double? Medium
        {
            get => double.TryParse(Medium_String, out double result) ? result : 0;
            set { }
        }
        [JsonProperty("Medium")]
        private string Medium_String { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none3")]
        public double? Small
        {
            get => double.TryParse(Small_String, out double result) ? result : 0;
            set { }
        }
        [JsonProperty("Small")]
        private string Small_String { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none4")]
        public double? Micro
        {
            get => double.TryParse(Micro_String, out double result) ? result : 0;
            set { }
        }
        [JsonProperty("Micro")]
        private string Micro_String { get; set; }
    }
}


using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class MorningStar
    {
        /// <summary>
        /// 
        /// </summary>
        public double? Ratio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Category_Benchmark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none")]
        public double? Sustainability_Ratio
        {
            get
            {
                return double.TryParse(Sustainability_Ratio_String, out double result) ? result : 0;
            }
            set
            {

            }
        }

        [JsonProperty("Sustainability_Ratio")]
        private string Sustainability_Ratio_String { get; set; }
    }
}


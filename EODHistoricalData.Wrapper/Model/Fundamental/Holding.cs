using Newtonsoft.Json;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Holding
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Exchange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sector { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Assets_%")]
        public double? AssetsPercent { get; set; }

    }
}

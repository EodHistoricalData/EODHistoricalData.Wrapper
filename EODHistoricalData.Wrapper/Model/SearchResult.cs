using System;

namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchResult
    {
        //"isPrimary":true,"previousClose":22.35,"previousCloseDate":"2026-02-26"}
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
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Isin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsPrimary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal PreviousClose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PreviousCloseDate { get; set; }

    }
}

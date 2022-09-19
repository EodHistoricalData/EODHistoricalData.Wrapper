using System;
using System.Collections.Generic;
using System.Text;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class ESGScores
    {
        /// <summary>
        /// 
        /// </summary>
        public string Disclaimer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? RatingDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalEsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalEsgPercentile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EnvironmentScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EnvironmentScorePercentile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? SocialScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? SocialScorePercentile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? GovernanceScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? GovernanceScorePercentile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ControversyLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, ActivitiesInvolvement> ActivitiesInvolvement { get; set; }
    }
}

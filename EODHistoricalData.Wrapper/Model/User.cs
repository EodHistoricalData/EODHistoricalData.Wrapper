using System;

namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SubscriptionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PaymentMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? ApiRequests { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ApiRequestsDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? DailyRateLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string InviteToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? InviteTokenClicked { get; set; }

    }
}

using System;

namespace EOD.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InsiderTransaction
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
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ReportDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? OwnerCik { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OwnerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OwnerRelationship { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OwnerTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TransactionCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? TransactionAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TransactionPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TransactionAcquiredDisposed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long? PostTransactionAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Link { get; set; }
    }
}


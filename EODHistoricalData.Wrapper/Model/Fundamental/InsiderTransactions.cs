using System;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class InsiderTransactions
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OwnerCik { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OwnerName { get; set; }
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
        public string SecLink { get; set; }
    }
}

using EOD.Utils;
using Newtonsoft.Json;
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
		[JsonProperty("Date")]
		private string DateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none0")]
		public DateTime? Date { get => GetDate.ParseDate(DateJSON); }
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
		[JsonProperty("TransactionDate")]
		private string TransactionDateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none1")]
		public DateTime? TransactionDate { get => GetDate.ParseDate(TransactionDateJSON); }
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

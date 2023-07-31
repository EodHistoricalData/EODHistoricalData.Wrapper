using Newtonsoft.Json;
using System;

namespace EOD.Model.BulkFundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Cash_FlowData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Filing_date { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        [JsonProperty ("currency_symbol")]
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Investments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ChangeToLiabilities { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalCashflowsFromInvestingActivities { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? NetBorrowings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalCashFromFinancingActivities { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? ChangeToOperatingActivities { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? NetIncome { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? ChangeInCash { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? BeginPeriodCashFlow { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? EndPeriodCashFlow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalCashFromOperatingActivities { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? IssuanceOfCapitalStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Depreciation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? OtherCashflowsFromInvestingActivities { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? DividendsPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ChangeToInventory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ChangeToAccountReceivables { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? SalePurchaseOfStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? OtherCashflowsFromFinancingActivities { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ChangeToNetincome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? CapitalExpenditures { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? ChangeReceivables { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? CashFlowsOtherOperating { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? ExchangeRateChanges { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? CashAndCashEquivalentsChanges { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? ChangeInWorkingCapital { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? StockBasedCompensation { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? OtherNonCashItems { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? FreeCashFlow { get; set; }
    }
}

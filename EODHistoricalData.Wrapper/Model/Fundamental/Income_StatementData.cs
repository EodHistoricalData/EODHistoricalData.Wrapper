using EOD.Utils;
using Newtonsoft.Json;
using System;

namespace EOD.Model.Fundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Income_StatementData
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
        [JsonProperty("Filing_date")]
        private string Filing_dateJSON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("none1")]
        public DateTime? Filing_date { get => GetDate.ParseDate(Filing_dateJSON); }
        /// <summary>
        /// 
        /// </summary>
        public string Currency_symbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ResearchDevelopment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? EffectOfAccountingCharges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? IncomeBeforeTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? MinorityInterest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? NetIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? SellingGeneralAdministrative { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? SellingAndMarketingExpenses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? GrossProfit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ReconciledDepreciation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Ebit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Ebitda { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? DepreciationAndAmortization { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? NonOperatingIncomeNetOther { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? OperatingIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? OtherOperatingExpenses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? InterestExpense { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TaxProvision { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? InterestIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? NetInterestIncome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? ExtraordinaryItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? NonRecurring { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? OtherItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? IncomeTaxExpense { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalRevenue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalOperatingExpenses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? CostOfRevenue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? TotalOtherIncomeExpenseNet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? DiscontinuedOperations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? NetIncomeFromContinuingOps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? NetIncomeApplicableToCommonShares { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? PreferredStockAndOtherAdjustments { get; set; }
    }
}

using Newtonsoft.Json;
using System;

namespace EOD.Model.BulkFundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Income_StatementData
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
        public string CurrensySymbol { get; set; }
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
        /// Extended
        /// </summary>
        public double? SellingAndMarketingExpenses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? GrossProfit { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? ReconciledDepreciation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Ebit { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? Ebitda { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? DepreciationAndAmortization { get; set; }
        /// <summary>
        /// Extended
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
        /// Extended
        /// </summary>
        public double? TaxProvision { get; set; }
        /// <summary>
        /// Extended
        /// </summary>
        public double? InterestIncome { get; set; }
        /// <summary>
        /// Extended
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
        /// Extended
        /// </summary>
        public double? PreferredStockAndOtherAdjustments { get; set; }
    }
}

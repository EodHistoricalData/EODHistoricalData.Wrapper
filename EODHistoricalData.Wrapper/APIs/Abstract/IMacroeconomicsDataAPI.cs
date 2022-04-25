using EOD.Model;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    /// <summary>
    /// Intraday Historical Data API
    /// </summary>
    internal interface IMacroIndicatorsAPI
    {
        Task<List<MacroIndicator>> GetDataAsync(string country, string indicator);
        Task<List<MacroeconomicsData>> GetMacroeconomicsDataAsync(string ticker);
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Report.FixedAsset;


namespace TSD.AccountingSoft.View.Report
{
    /// <summary>
    /// Interface IFixedAssetHousingReportsView
    /// </summary>
    public interface IFixedAssetHousingReportsView : IView
    {
        /// <summary>
        /// Sets the budget chapters.
        /// </summary>
        /// <value>The budget chapters.</value>
        IList<FixedAssetHousingReportModel> FixedAssetHousingReports { set; }
    }
}


using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Report;


namespace TSD.AccountingSoft.View.Report
{
    /// <summary>
    /// interface IReportView
    /// </summary>
    public interface IReportView : IView
    {
        /// <summary>
        /// Sets the report lists.
        /// </summary>
        /// <value>
        /// The report lists.
        /// </value>
        List<ReportListModel> ReportLists {set; }
    }
}

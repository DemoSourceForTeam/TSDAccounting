

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Report;

namespace TSD.AccountingSoft.View.Report
{
    /// <summary>
    /// interface IReportGroupView
    /// </summary>
    public interface IReportGroupView : IView
    {
        /// <summary>
        /// Sets the report groups.
        /// </summary>
        /// <value>
        /// The report groups.
        /// </value>
        List<ReportGroupModel> ReportGroups { set; }
    }
}

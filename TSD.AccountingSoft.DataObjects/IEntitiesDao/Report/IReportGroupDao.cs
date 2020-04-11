
using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Report;

namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Report
{
    /// <summary>
    /// IReportGroupDao
    /// </summary>
    public interface IReportGroupDao
    {
        /// <summary>
        /// Gets the report lists.
        /// </summary>
        /// <returns></returns>
        List<ReportGroupEntity> GetReportGroups();

        /// <summary>
        /// Gets the report group by identifier.
        /// </summary>
        /// <param name="reportGroupID">The report group identifier.</param>
        /// <returns></returns>
        ReportGroupEntity GetReportGroupByID(int reportGroupID);
    }
}

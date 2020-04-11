
using System.Linq;
using TSD.AccountingSoft.BusinessComponents.Messages.Report;
using TSD.AccountingSoft.DataAccess.IEntitiesDao.Report;

namespace TSD.AccountingSoft.BusinessComponents.Facade.Report
{
    public class ReportGroupFacade
    {
        private static readonly IReportGroupDao ReportGroupDao = DataAccess.DataAccess.ReportGroupDao;
        public ReportGroupResponse GetReportGroups(ReportGroupRequest request)
        {
            var response = new ReportGroupResponse();

            if (request.LoadOptions.Contains("ReportGroups")) response.ReportGroups = ReportGroupDao.GetReportGroups();
            if (request.LoadOptions.Contains("ReportGroup")) response.ReportGroup = ReportGroupDao.GetReportGroupByID(request.ReportGroupID);

            return response;
        }
    }
}

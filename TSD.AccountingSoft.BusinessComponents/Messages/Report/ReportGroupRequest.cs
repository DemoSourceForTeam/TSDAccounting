

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Report
{
    public class ReportGroupRequest : RequestBase
    {
        
        public int ReportGroupID { get; set; }
        /// <summary>
        /// Gets or sets the report list.
        /// </summary>
        /// <value>
        /// The report list.
        /// </value>
        public ReportGroupEntity ReportGroup { get; set; }
    }
}

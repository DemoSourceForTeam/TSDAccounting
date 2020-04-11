

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Report
{
    /// <summary>
    /// Report Group Response
    /// </summary>
    public class FixedAssetHousingReportResponse : ResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedAssetHousingReportResponse"/> class.
        /// </summary>
        public FixedAssetHousingReportResponse() { }

        /// <summary>
        /// The budget chapters
        /// </summary>
        public IList<FixedAssetHousingReportEntity> FixedAssetHousingReports;

        /// <summary>
        /// The budget chapter
        /// </summary>
        public FixedAssetHousingReportEntity FixedAssetHousingReport;

        /// <summary>
        /// Gets or sets the budget chapter identifier.
        /// </summary>
        /// <value>The budget chapter identifier.</value>
        public int FixedAssetHousingReportId { get; set; }
    }
}

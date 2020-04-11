

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Report
{
    public class FixedAssetHousingReportRequest : RequestBase
    {

        /// <summary>
        /// Gets or sets the fixed asset housing report identifier.
        /// </summary>
        /// <value>
        /// The fixed asset housing report identifier.
        /// </value>
        public int FixedAssetHousingReportId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is active].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is active]; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }
        /// <summary>
        /// Gets or sets the report list.
        /// </summary>
        /// <value>
        /// The report list.
        /// </value>
        public FixedAssetHousingReportEntity FixedAssetHousingReport { get; set; }
    }
}

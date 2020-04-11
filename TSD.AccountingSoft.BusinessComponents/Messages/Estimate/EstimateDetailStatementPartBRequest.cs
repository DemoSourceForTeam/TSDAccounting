

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report.Estimate;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Estimate
{
    /// <summary>
    /// class EstimateDetailStatementPartBRequest
    /// </summary>
    public class EstimateDetailStatementPartBRequest : RequestBase
    {
        /// <summary>
        /// The estimate detail statement
        /// </summary>
        public IList<EstimateDetailStatementPartBEntity> EstimateDetailStatementPartBs;

        /// <summary>
        /// The estimate detail statement part b identifier
        /// </summary>
        public int EstimateDetailStatementPartBId;
    }
}

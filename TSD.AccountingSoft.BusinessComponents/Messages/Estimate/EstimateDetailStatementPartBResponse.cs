

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report.Estimate;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Estimate
{
    /// <summary>
    /// class EstimateDetailStatementPartBResponse
    /// </summary>
    public class EstimateDetailStatementPartBResponse : ResponseBase
    {
        /// <summary>
        /// The estimates
        /// </summary>
        public IList<EstimateDetailStatementPartBEntity> EstimateDetailStatementPartBs;

        /// <summary>
        /// The estimate detail statement part b identifier
        /// </summary>
        public int EstimateDetailStatementPartBId ;
    }
}

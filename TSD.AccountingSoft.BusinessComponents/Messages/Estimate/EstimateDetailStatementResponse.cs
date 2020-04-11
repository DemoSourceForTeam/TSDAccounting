

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report.Estimate;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Estimate
{
    /// <summary>
    /// EstimateDetailStatementResponse
    /// </summary>
    public class EstimateDetailStatementResponse : ResponseBase
    {
        /// <summary>
        /// The estimates
        /// </summary>
        public IList<EstimateDetailStatementInfoEntity> EstimateDetailStatements;

        /// <summary>
        /// The estimate
        /// </summary>
        public EstimateDetailStatementInfoEntity EstimateDetailStatement;

        /// <summary>
        /// The reference identifier
        /// </summary>
        public int EstimateDetailStatementId;
    }
}

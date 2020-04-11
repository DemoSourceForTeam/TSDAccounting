

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report.Estimate;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Estimate
{
    /// <summary>
    /// class EstimateDetailStatementFixedAssetResponse
    /// </summary>
    public class EstimateDetailStatementFixedAssetResponse : ResponseBase
    {
        /// <summary>
        /// The estimates
        /// </summary>
        public IList<EstimateDetailStatementFixedAssetEntity> EstimateDetailStatementFixedAssets;

        /// <summary>
        /// The estimate detail statement part b identifier
        /// </summary>
        public int EstimateDetailStatementFixedAssetId;
    }
}

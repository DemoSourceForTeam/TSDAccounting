

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report.Estimate;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Estimate
{
    /// <summary>
    /// class EstimateDetailStatementFixedAssetRequest
    /// </summary>
    public class EstimateDetailStatementFixedAssetRequest : RequestBase
    {
        /// <summary>
        /// The estimate detail statement
        /// </summary>
        public IList<EstimateDetailStatementFixedAssetEntity> EstimateDetailStatementFixedAssets;

        /// <summary>
        /// The estimate detail statement part b identifier
        /// </summary>
        public int EstimateDetailStatementFixedAssetId;
    }
}

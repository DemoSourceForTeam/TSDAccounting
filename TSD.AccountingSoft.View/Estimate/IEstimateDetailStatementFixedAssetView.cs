

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Report.Estimate;


namespace TSD.AccountingSoft.View.Estimate
{
    /// <summary>
    /// interface IEstimateDetailStatementFixedAssetView
    /// </summary>
    public interface IEstimateDetailStatementFixedAssetView : IView
    {
        /// <summary>
        /// Sets the payment estimates.
        /// </summary>
        /// <value>The payment estimates.</value>
        IList<EstimateDetailStatementFixedAssetModel> EstimateDetailStatementFixedAsset { set; }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Report.Estimate;

namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Estimate
{
    public interface IEstimateDetailStatementFixedAssetDao
    {
        /// <summary>
        /// Gets the budgetSourceCategories.
        /// </summary>
        /// <returns></returns>
        List<EstimateDetailStatementFixedAssetEntity> GetEstimateDetailStatementFixedAssets();

        /// <summary>
        /// Inserts the estimateDetailStatement.
        /// </summary>
        /// <param name="estimateDetailStatement">The estimateDetailStatement.</param>
        /// <returns></returns>
        int InsertEstimateDetailStatementFixedAsset(EstimateDetailStatementFixedAssetEntity estimateDetailStatement);

        /// <summary>
        /// Updates the estimateDetailStatement.
        /// </summary>
        /// <param name="estimateDetailStatement">The estimateDetailStatement.</param>
        /// <returns></returns>
        string UpdateEstimateDetailStatementFixedAsset(EstimateDetailStatementFixedAssetEntity estimateDetailStatement);

        /// <summary>
        /// Deletes the estimateDetailStatement.
        /// </summary>
        /// <returns></returns>
        string DeleteEstimateDetailStatementFixedAsset();
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Report.Estimate;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Estimate
{
    /// <summary>
    /// IEstimateDetailStatementDao
    /// </summary>
   public interface IEstimateDetailStatementDao
    {
        /// <summary>
        /// Gets the estimateDetailStatement.
        /// </summary>
        /// <param name="isActive">if set to <c>true</c> [is active].</param>
        /// <returns></returns>
        EstimateDetailStatementInfoEntity GetEstimateDetailStatement(bool isActive);

        EstimateDetailStatementInfoEntity GetCompanyProfileInfo(bool isActive);
        /// <summary>
        /// Gets the budgetSourceCategories.
        /// </summary>
        /// <returns></returns>
        List<EstimateDetailStatementInfoEntity> GetEstimateDetailStatements();

        /// <summary>
        /// Inserts the estimateDetailStatement.
        /// </summary>
        /// <param name="estimateDetailStatement">The estimateDetailStatement.</param>
        /// <returns></returns>
        int InsertEstimateDetailStatement(EstimateDetailStatementInfoEntity estimateDetailStatement);

        /// <summary>
        /// Updates the estimateDetailStatement.
        /// </summary>
        /// <param name="estimateDetailStatement">The estimateDetailStatement.</param>
        /// <returns></returns>
        string UpdateEstimateDetailStatement(EstimateDetailStatementInfoEntity estimateDetailStatement);

        /// <summary>
        /// Deletes the estimateDetailStatement.
        /// </summary>
        /// <param name="estimateDetailStatement">The estimateDetailStatement.</param>
        /// <returns></returns>
        string DeleteEstimateDetailStatement(EstimateDetailStatementInfoEntity estimateDetailStatement);
    }
}

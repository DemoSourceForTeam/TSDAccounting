

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{

    /// <summary>
    /// Interface IMergerFundDao
    /// </summary>
    public interface IMergerFundDao
    {

        /// <summary>
        /// Gets the merger fund.
        /// </summary>
        /// <param name="mergerFundId">The merger fund identifier.</param>
        /// <returns>MergerFundEntity.</returns>
        MergerFundEntity GetMergerFund(int mergerFundId);

        /// <summary>
        /// Gets the merger funds.
        /// </summary>
        /// <returns>List{MergerFundEntity}.</returns>
        List<MergerFundEntity> GetMergerFunds();

        /// <summary>
        /// Gets the merger funds for combo tree.
        /// </summary>
        /// <param name="mergerFundId">The merger fund identifier.</param>
        /// <returns>List{MergerFundEntity}.</returns>
        List<MergerFundEntity> GetMergerFundsForComboTree(int mergerFundId);

        /// <summary>
        /// Gets the merger funds by active.
        /// </summary>
        /// <param name="isActive">if set to <c>true</c> [is active].</param>
        /// <returns>List{MergerFundEntity}.</returns>
        List<MergerFundEntity> GetMergerFundsByActive(bool isActive);

        /// <summary>
        /// Inserts the merger fund.
        /// </summary>
        /// <param name="mergerFund">The merger fund.</param>
        /// <returns>System.Int32.</returns>
        int InsertMergerFund(MergerFundEntity mergerFund);

        /// <summary>
        /// Updates the merger fund.
        /// </summary>
        /// <param name="mergerFund">The merger fund.</param>
        /// <returns>System.String.</returns>
        string UpdateMergerFund(MergerFundEntity mergerFund);

        /// <summary>
        /// Deletes the merger fund.
        /// </summary>
        /// <param name="mergerFund">The merger fund.</param>
        /// <returns>System.String.</returns>
        string DeleteMergerFund(MergerFundEntity mergerFund);
    }
}
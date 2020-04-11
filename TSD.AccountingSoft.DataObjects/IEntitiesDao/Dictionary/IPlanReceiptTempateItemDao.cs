

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{
    /// <summary>
    /// interface IBudgetItemDao
    /// </summary>
    public interface IPlanReceiptTempateItemDao
    {
        /// <summary>
        /// Gets the plan receipt tempate item.
        /// </summary>
        /// <returns></returns>
       IList<PlanReceiptTempateItemEntity> GetPlanReceiptTempateItems();

       /// <summary>
       /// Gets the plan receipt tempate item.
       /// </summary>
       /// <param name="planReceiptTempateItemId">The budget item identifier.</param>
       /// <returns></returns>
       PlanReceiptTempateItemEntity GetPlanReceiptTempateItem(int planReceiptTempateItemId);
       
    }

}

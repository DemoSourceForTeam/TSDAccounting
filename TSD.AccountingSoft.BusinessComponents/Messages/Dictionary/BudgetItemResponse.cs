

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class BudgetItemResponse.
    /// </summary>
    public class BudgetItemResponse : ResponseBase
    {
        /// <summary>
        /// The budget item
        /// </summary>
        public IList<BudgetItemEntity> BudgetItems;

        /// <summary>
        /// The budget item
        /// </summary>
        public BudgetItemEntity BudgetItem;

        /// <summary>
        /// The budget item identifier
        /// </summary>
        public int BudgetItemId;

        /// <summary>
        /// The budget item type
        /// </summary>
        public int BudgetItemType;
    }
}

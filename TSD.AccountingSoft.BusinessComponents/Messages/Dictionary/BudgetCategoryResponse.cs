

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class BudgetCategoryResponse.
    /// </summary>
    public class BudgetCategoryResponse : ResponseBase
    {
        /// <summary>
        /// The budget categories
        /// </summary>
        public IList<BudgetCategoryEntity> BudgetCategories;

        /// <summary>
        /// The budget category
        /// </summary>
        public BudgetCategoryEntity BudgetCategory;

        /// <summary>
        /// The budget category identifier
        /// </summary>
        public int BudgetCategoryId;
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// class BudgetSourceCategoryResponse
    /// </summary>
    public class BudgetSourceCategoryResponse : ResponseBase
    {
        /// <summary>
        /// The budgetSourceCategorys
        /// </summary>
        public IList<BudgetSourceCategoryEntity> BudgetSourceCategories;

        /// <summary>
        /// The budgetSourceCategory
        /// </summary>
        public BudgetSourceCategoryEntity BudgetSourceCategory;

        /// <summary>
        /// Gets or sets the budgetSourceCategory identifier.
        /// </summary>
        /// <value>
        /// The budgetSourceCategory identifier.
        /// </value>
        public int BudgetSourceCategoryId { get; set; }
    }
}

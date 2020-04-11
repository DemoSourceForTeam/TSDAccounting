

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// class BudgetSourceCategoryRequest
    /// </summary>
    public class BudgetSourceCategoryRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the budgetSourceCategory identifier.
        /// </summary>
        /// <value>
        /// The budgetSourceCategory identifier.
        /// </value>
        public int BudgetSourceCategoryId { get; set; }

        /// <summary>
        /// The budgetSourceCategory
        /// </summary>
        public BudgetSourceCategoryEntity BudgetSourceCategory;
    }
}

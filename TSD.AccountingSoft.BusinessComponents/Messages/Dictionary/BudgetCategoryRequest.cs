

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class BudgetCategoryRequest.
    /// </summary>
    public class BudgetCategoryRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the budget category identifier.
        /// </summary>
        /// <value>The budget category identifier.</value>
        public int BudgetCategoryId { get; set; }

        /// <summary>
        /// The budget category
        /// </summary>
        public BudgetCategoryEntity BudgetCategory;
    }
}

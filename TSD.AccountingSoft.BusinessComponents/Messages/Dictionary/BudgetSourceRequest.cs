

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class BudgetSourceRequest.
    /// </summary>
    public class BudgetSourceRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the budget source identifier.
        /// </summary>
        /// <value>The budget source identifier.</value>
        public int BudgetSourceId { get; set; }

        /// <summary>
        /// The budget source
        /// </summary>
        public BudgetSourceEntity BudgetSource;

        /// <summary>
        /// Gets or sets a value indicating whether [is parent].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is parent]; otherwise, <c>false</c>.
        /// </value>
        public bool IsParent { get; set; }

    }
}

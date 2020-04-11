

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class BudgetChapterRequest.
    /// </summary>
    public class BudgetChapterRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the budget chapter identifier.
        /// </summary>
        /// <value>The budget chapter identifier.</value>
        public int BudgetChapterId { get; set; }

        /// <summary>
        /// The budget chapter
        /// </summary>
        public BudgetChapterEntity BudgetChapter;
    }
}

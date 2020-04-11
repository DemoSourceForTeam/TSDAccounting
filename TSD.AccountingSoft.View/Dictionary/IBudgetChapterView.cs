

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IBudgetChapterView
    /// </summary>
    public interface IBudgetChapterView : IView
    {
        /// <summary>
        /// Gets or sets the budget chapter identifier.
        /// </summary>
        /// <value>The budget chapter identifier.</value>
        int BudgetChapterId { get; set; }

        /// <summary>
        /// Gets or sets the budget chapter code.
        /// </summary>
        /// <value>The budget chapter code.</value>
        string BudgetChapterCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget chapter.
        /// </summary>
        /// <value>The name of the budget chapter.</value>
        string BudgetChapterName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is system.
        /// </summary>
        /// <value><c>true</c> if this instance is system; otherwise, <c>false</c>.</value>
        bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the name of the foreign.
        /// </summary>
        /// <value>The name of the foreign.</value>
        string ForeignName { get; set; }
    }
}

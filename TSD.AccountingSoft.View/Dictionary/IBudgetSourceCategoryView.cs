﻿

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IBudgetSourceCategoryView
    /// </summary>
    public interface IBudgetSourceCategoryView : IView
    {
        /// <summary>
        /// Gets or sets the budget source category identifier.
        /// </summary>
        /// <value>
        /// The budget source category identifier.
        /// </value>
        int BudgetSourceCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the budget source category code.
        /// </summary>
        /// <value>
        /// The budget source category code.
        /// </value>
        string BudgetSourceCategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget source category.
        /// </summary>
        /// <value>
        /// The name of the budget source category.
        /// </value>
        string BudgetSourceCategoryName { get; set; }

        /// <summary>
        /// Gets or sets the name of the foreign.
        /// </summary>
        /// <value>
        /// The name of the foreign.
        /// </value>
        string ForeignName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is active].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is active]; otherwise, <c>false</c>.
        /// </value>
        bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is summary estimate report].
        /// </summary>
        /// <value>
        /// <c>true</c> if [is summary estimate report]; otherwise, <c>false</c>.
        /// </value>
        bool IsSummaryEstimateReport { get; set; }
    }
}

﻿

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IPlanTemplateItemView
    /// </summary>
    public interface IPlanTemplateItemView : IView
    {
        /// <summary>
        /// Gets or sets the plan template item identifier.
        /// </summary>
        /// <value>The plan template item identifier.</value>
        int PlanTemplateItemId { get; set; }

        /// <summary>
        /// Gets or sets the plan template list identifier.
        /// </summary>
        /// <value>The plan template list identifier.</value>
        int PlanTemplateListId { get; set; }

        /// <summary>
        /// Gets or sets the budget item identifier.
        /// </summary>
        /// <value>The budget item identifier.</value>
        string BudgetItemCode { get; set; }
    }
}


using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IPlanTemplateItemsView
    /// </summary>
    public interface IPlanTemplateItemsView : IView
    {
        /// <summary>
        /// Sets the BudgetItems.
        /// </summary>
        /// <value>The BudgetItems.</value>
        IList<PlanTemplateItemModel> PlanTemplateItems { set; }
    }
}

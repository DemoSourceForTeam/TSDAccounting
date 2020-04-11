

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IPlanTemplateListsView
    /// </summary>
    public interface IPlanTemplateListsView : IView
    {
        /// <summary>
        /// Sets the BudgetItems.
        /// </summary>
        /// <value>The BudgetItems.</value>
        IList<PlanTemplateListModel> PlanTemplateLists { set; }
    }
}

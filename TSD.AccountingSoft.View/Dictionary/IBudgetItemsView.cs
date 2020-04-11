

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IBudgetItemsView
    /// </summary>
    public interface IBudgetItemsView : IView
    {
        /// <summary>
        /// Sets the BudgetItems.
        /// </summary>
        /// <value>The BudgetItems.</value>
        IList<BudgetItemModel> BudgetItems { set; }
    }
}
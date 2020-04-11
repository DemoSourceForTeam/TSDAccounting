

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IBudgetSourcesView
    /// </summary>
    public interface IBudgetSourcesView : IView
    {
        /// <summary>
        /// Sets the budget sources.
        /// </summary>
        /// <value>The budget sources.</value>
        IList<BudgetSourceModel> BudgetSources { set; }
    }
}

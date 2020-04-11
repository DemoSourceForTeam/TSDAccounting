

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IBudgetChaptersView
    /// </summary>
    public interface IBudgetChaptersView : IView
    {
        /// <summary>
        /// Sets the budget chapters.
        /// </summary>
        /// <value>The budget chapters.</value>
        IList<BudgetChapterModel> BudgetChapters { set; }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IBudgetSourceCategoriesView
    /// </summary>
    public interface IBudgetSourceCategoriesView : IView
    {
        /// <summary>
        /// Sets the budget source categories.
        /// </summary>
        /// <value>
        /// The budget source categories.
        /// </value>
        IList<BudgetSourceCategoryModel> BudgetSourceCategories { set; }
    }
}

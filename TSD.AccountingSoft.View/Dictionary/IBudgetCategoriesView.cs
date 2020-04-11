

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IBudgetCategoriesView
    /// </summary>
    public interface IBudgetCategoriesView:IView
    {
        /// <summary>
        /// Sets the budget categories.
        /// </summary>
        /// <value>The budget categories.</value>
        IList<BudgetCategoryModel> BudgetCategories { set; }
    }
}

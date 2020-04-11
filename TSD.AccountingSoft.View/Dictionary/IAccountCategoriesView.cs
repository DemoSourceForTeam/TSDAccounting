

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IAccountCategoriesView
    /// </summary>
    public interface IAccountCategoriesView : IView
    {
        /// <summary>
        /// Sets the account categories.
        /// </summary>
        /// <value>The account categories.</value>
        IList<AccountCategoryModel> AccountCategories { set; }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// FixedAssetCategory view interface
    /// </summary>
    public interface IFixedAssetCategoriesView : IView
    {
        /// <summary>
        /// Sets the fixed asset categories.
        /// </summary>
        /// <value>The fixed asset categories.</value>
        IList<FixedAssetCategoryModel> FixedAssetCategories { set; }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// FixedAssets View Interface
    /// </summary>
    public interface IFixedAssetsView : IView
    {
        /// <summary>
        /// Sets the fixed assets.
        /// </summary>
        /// <value>
        /// The fixed assets.
        /// </value>
        IList<FixedAssetModel> FixedAssets { set; }
    }
}

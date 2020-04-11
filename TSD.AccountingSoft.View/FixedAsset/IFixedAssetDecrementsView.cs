

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.FixedAsset;

namespace TSD.AccountingSoft.View.FixedAsset
{
    /// <summary>
    /// interface IFixedAssetDecrementsView:IView
    /// </summary>
    public interface IFixedAssetDecrementsView:IView
    {
        /// <summary>
        /// Sets the fixed asset decrement.
        /// </summary>
        /// <value>
        /// The fixed asset decrement.
        /// </value>
        IList<FixedAssetDecrementModel> FixedAssetDecrements { set; }

        /// <summary>
        /// Sets the fixed asset decrement details.
        /// </summary>
        /// <value>
        /// The fixed asset decrement details.
        /// </value>
        IList<FixedAssetDecrementDetailModel> FixedAssetDecrementDetails { set; }
    }
}

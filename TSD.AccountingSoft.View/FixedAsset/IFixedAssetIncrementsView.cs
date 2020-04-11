

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.FixedAsset;


namespace TSD.AccountingSoft.View.FixedAsset
{
    /// <summary>
    /// interface IFixedAssetIncrementsView
    /// </summary>
    public interface IFixedAssetIncrementsView : IView
    {
        /// <summary>
        /// Sets the fixed asset increment.
        /// </summary>
        /// <value>
        /// The fixed asset increment.
        /// </value>
        IList<FixedAssetIncrementModel> FixedAssetIncrements { set; }

        IList<FixedAssetIncrementDetailModel> FixedAssetIncrementDetails { set; }
    }
}

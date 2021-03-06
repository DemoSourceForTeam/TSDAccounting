﻿

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.FixedAsset;


namespace TSD.AccountingSoft.View.FixedAsset
{
    /// <summary>
    /// IFixedAssetArmortizationsView
    /// </summary>
    public interface IFixedAssetArmortizationsView : IView
    {
        /// <summary>
        /// Sets the fixed asset armortizations.
        /// </summary>
        /// <value>
        /// The fixed asset armortizations.
        /// </value>
        IList<FixedAssetArmortizationModel> FixedAssetArmortizations { set; }
    }
}

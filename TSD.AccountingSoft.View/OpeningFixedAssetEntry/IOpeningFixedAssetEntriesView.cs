

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Opening;

namespace TSD.AccountingSoft.View.OpeningFixedAssetEntry
{
    /// <summary>
    /// interface IOpeningAccountEntriesView
    /// </summary>
    public interface IOpeningFixedAssetEntriesView : IView
    {
        /// <summary>
        /// Sets the opening account entries.
        /// </summary>
        /// <value>
        /// The opening account entries.
        /// </value>
        IList<OpeningFixedAssetEntryModel> OpeningFixedAssetEntries { get; set; }
    }
}

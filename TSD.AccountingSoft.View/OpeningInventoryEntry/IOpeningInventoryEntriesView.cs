

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Opening;

namespace TSD.AccountingSoft.View.OpeningInventoryEntry
{
    /// <summary>
    /// interface IOpeningAccountEntriesView
    /// </summary>
    public interface IOpeningInventoryEntriesView : IView
    {
        /// <summary>
        /// Sets the opening account entries.
        /// </summary>
        /// <value>
        /// The opening account entries.
        /// </value>
        IList<OpeningInventoryEntryModel> OpeningInventoryEntries { get; set; }
    }
}

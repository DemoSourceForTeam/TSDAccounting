

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Opening;


namespace TSD.AccountingSoft.View.OpeningAccountEntry
{
    /// <summary>
    /// interface IOpeningAccountEntriesView
    /// </summary>
    public interface IOpeningAccountEntriesView : IView
    {
        /// <summary>
        /// Sets the opening account entries.
        /// </summary>
        /// <value>
        /// The opening account entries.
        /// </value>
        IList<OpeningAccountEntryModel> OpeningAccountEntries { get; set; }
    }
}

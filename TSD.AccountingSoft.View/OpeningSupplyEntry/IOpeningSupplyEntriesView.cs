

using TSD.AccountingSoft.Model.BusinessObjects.Opening;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.AccountingSoft.View.OpeningSupplyEntry
{
    /// <summary>
    /// Interface IOpeningSupplyEntriesView
    /// </summary>
    /// <seealso cref="TSD.AccountingSoft.View.IView" />
    public interface IOpeningSupplyEntriesView : IView
    {
        /// <summary>
        /// Sets the opening account entries.
        /// </summary>
        /// <value>The opening account entries.</value>
        IList<OpeningSupplyEntryModel> OpeningSupplyEntries { get; set; }
    }
}

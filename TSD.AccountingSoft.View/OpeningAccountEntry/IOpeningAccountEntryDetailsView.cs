

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Opening;


namespace TSD.AccountingSoft.View.OpeningAccountEntry
{
    /// <summary>
    /// IOpeningAccountEntryDetailsView
    /// </summary>
    public interface IOpeningAccountEntryDetailsView : IView
    {
        /// <summary>
        /// Gets or sets the opening account entry details.
        /// </summary>
        /// <value>
        /// The opening account entry details.
        /// </value>
        IList<OpeningAccountEntryDetailModel> OpeningAccountEntryDetails { get; set; }
    }
}
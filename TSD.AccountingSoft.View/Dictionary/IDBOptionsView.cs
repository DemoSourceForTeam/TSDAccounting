

using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using System.Collections.Generic;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IDBOptionsView
    /// </summary>
    public interface IDBOptionsView : IView
    {
        /// <summary>
        /// Gets or sets the database options.
        /// </summary>
        /// <value>
        /// The database options.
        /// </value>
        IList<DBOptionModel> DBOptions { get; set; }
    }
}

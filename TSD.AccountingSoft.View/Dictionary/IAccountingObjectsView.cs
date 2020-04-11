

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IAccountingObjectsView interface
    /// </summary>
    public interface IAccountingObjectsView:IView
    {
        /// <summary>
        /// Sets the accounting objects.
        /// </summary>
        /// <value>
        /// The accounting objects.
        /// </value>
        IList<AccountingObjectModel> AccountingObjects { set; }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IAccountsView
    /// </summary>
   public interface IAccountsView : IView
    {
        /// <summary>
        /// Sets the accounts.
        /// </summary>
        /// <value>
        /// The accounts.
        /// </value>
       IList<AccountModel> Accounts { set; }
    }
}

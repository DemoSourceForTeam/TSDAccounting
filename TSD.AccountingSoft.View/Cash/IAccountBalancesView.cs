

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Cash;


namespace TSD.AccountingSoft.View.Cash
{
    public interface IAccountBalancesView : IView
    {
        /// <summary>
        /// Sets the account balances.
        /// </summary>
        /// <value>
        /// The account balances.
        /// </value>
        IList<AccountBalanceModel> AccountBalances { set; }
    }
}

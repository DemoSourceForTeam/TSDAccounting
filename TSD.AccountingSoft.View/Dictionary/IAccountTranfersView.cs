

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IAccountTranfersView
    /// </summary>
    public interface IAccountTranfersView : IView
    {
        /// <summary>
        /// Sets the account tranfers.
        /// </summary>
        /// <value>
        /// The account tranfers.
        /// </value>
        IList<AccountTranferModel> AccountTranfers { set; }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Deposit;


namespace TSD.AccountingSoft.View.Deposit
{
    /// <summary>
    /// Interface IReceiptDepositsView
    /// </summary>
    public interface IReceiptDepositsView : IView
    {
        /// <summary>
        /// Sets the receipt deposits.
        /// </summary>
        /// <value>
        /// The receipt deposits.
        /// </value>
        IList<DepositModel> ReceiptDeposits { set; }

        IList<DepositDetailModel> ReceiptDepositDetails { set; }
    }
}

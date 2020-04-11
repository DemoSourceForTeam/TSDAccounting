

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Cash;


namespace TSD.AccountingSoft.View.Cash
{

    /// <summary>
    /// IPaymentVouchersView interface
    /// </summary>
    public interface IPaymentVouchersView : IView
    {
        /// <summary>
        /// Sets the payment vouchers.
        /// </summary>
        /// <value>
        /// The payment vouchers.
        /// </value>
        IList<CashModel> PaymentVouchers { set; }

        IList<CashDetailModel> PaymentVoucherDetails { set; }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Cash;


namespace TSD.AccountingSoft.View.Cash
{

    /// <summary>
    /// IReceiptVouchersView class
    /// </summary>
    public interface IReceiptVouchersView : IView
    {
        /// <summary>
        /// Sets the receipt vouchers.
        /// </summary>
        /// <value>
        /// The receipt vouchers.
        /// </value>
        IList<ReceiptVoucherModel> ReceiptVouchers { set; }

        IList<ReceiptVoucherDetailModel> ReceiptVoucherDetails { set; }
       

        
    }
}

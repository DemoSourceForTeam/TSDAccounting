

using System;
using TSD.AccountingSoft.View.Cash;


namespace TSD.AccountingSoft.Presenter.Cash.ReceiptVoucher
{
    /// <summary>
    /// ReceiptVouchersPresenter class
    /// </summary>
    public class ReceiptVouchersPresenter : Presenter<IReceiptVouchersView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptVouchersPresenter" /> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public ReceiptVouchersPresenter(IReceiptVouchersView view)
            : base(view)
        {
        }

        public void Display(int refTypeId)
        {
            View.ReceiptVouchers = Model.GetReceiptVoucherByRefTypeId(refTypeId);
        }

        public void DisplayVoucherDetail(long refId)
        {
            var voucher = Model.GetReceiptVoucher(refId);
            if (voucher != null)
            {
                View.ReceiptVoucherDetails = voucher.ReceiptVoucherDetails;
            }
        }

        /// <summary>
        /// Deletes the specified reference identifier.
        /// </summary>
        /// <param name="refId">The reference identifier.</param>
        /// <returns></returns>
        public long Delete(long refId)
        {
            return Model.DeleteReceiptVoucher(refId);
        }
    }
}

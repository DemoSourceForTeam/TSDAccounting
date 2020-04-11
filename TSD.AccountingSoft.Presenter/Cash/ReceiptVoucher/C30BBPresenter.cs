

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Report.Voucher;
using TSD.AccountingSoft.View.Cash;


namespace TSD.AccountingSoft.Presenter.Cash.ReceiptVoucher
{

    /// <summary>
    /// ReceiptVoucherPresenter
    /// </summary>
 public   class C30BBPresenter : Presenter<IC30BBView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptVoucherPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
     public C30BBPresenter(IC30BBView view)
            : base(view)
        {
        }
        public void Display(int year, int refTypeId)
        {
            IList<C30BBModel> voucher = Model.GetC30BBWithStoreProdure(year, refTypeId);
            List<C30BBModel> lstModel = new List<C30BBModel>();
            foreach (C30BBModel it in voucher)
            {
                lstModel.Add(it);
            }
            View.C30BBList = lstModel;
        }
    }
}

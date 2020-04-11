

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{

    /// <summary>
    /// IVoucherListsView interface
    /// </summary>
    public interface IVoucherListsView:IView
    {
        /// <summary>
        /// Sets the voucher lists.
        /// </summary>
        /// <value>
        /// The voucher lists.
        /// </value>
        IList<VoucherListModel> VoucherLists { set; }
    }
}

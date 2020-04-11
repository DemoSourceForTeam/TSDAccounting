

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    public interface IVoucherTypesView : IView
    {
        /// <summary>
        /// Sets the voucher types.
        /// </summary>
        /// <value>
        /// The voucher types.
        /// </value>
        IList<VoucherTypeModel> VoucherTypes { set; }
    }
}

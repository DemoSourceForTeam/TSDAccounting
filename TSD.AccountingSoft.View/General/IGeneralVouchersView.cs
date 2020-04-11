

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.General;


namespace TSD.AccountingSoft.View.General
{
    /// <summary>
    /// interface IGeneralVouchersView
    /// </summary>
    public interface IGeneralVouchersView
    {
        IList<GeneralVocherModel> GeneralVouchers { set; }
        IList<GeneralDetailModel> GeneralVoucherDetails { set; }
    }
}

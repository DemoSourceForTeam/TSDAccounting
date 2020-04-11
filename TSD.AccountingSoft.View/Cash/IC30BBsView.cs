

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Report.Voucher;

namespace TSD.AccountingSoft.View.Cash
{
    /// <summary>
    /// interface IC30BBsVie
    /// </summary>
    public interface IC30BBsView : IView
    {
        /// <summary>
        /// Sets the C30 b bs.
        /// </summary>
        /// <value>
        /// The C30 b bs.
        /// </value>
        IList<C30BBModel> C30BBs { set; }
    }
}

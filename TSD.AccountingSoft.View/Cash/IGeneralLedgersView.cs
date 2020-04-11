

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Cash;


namespace TSD.AccountingSoft.View.Cash
{
    /// <summary>
    /// interface IGeneralLedgersView
    /// </summary>
    public interface IGeneralLedgersView : IView
    {
        /// <summary>
        /// Sets the general ledgers.
        /// </summary>
        /// <value>
        /// The general ledgers.
        /// </value>
        IList<GeneralLedgerModel> GeneralLedgers { set; }
    }
}

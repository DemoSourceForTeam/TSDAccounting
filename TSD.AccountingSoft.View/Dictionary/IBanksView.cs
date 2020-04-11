

using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using System.Collections.Generic;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IBanksView
    /// </summary>
    public interface IBanksView : IView
    {
        /// <summary>
        /// Sets the banks.
        /// </summary>
        /// <value>
        /// The banks.
        /// </value>
        IList<BankModel> Banks { set; }
    }
}
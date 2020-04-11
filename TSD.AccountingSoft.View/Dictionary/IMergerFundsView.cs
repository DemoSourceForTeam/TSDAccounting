

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IMergerFundsView
    /// </summary>
    public interface IMergerFundsView : IView
    {
        /// <summary>
        /// Sets the merger funds.
        /// </summary>
        /// <value>The merger funds.</value>
        IList<MergerFundModel> MergerFunds { set; }
    }
}

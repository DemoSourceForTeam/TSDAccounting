

using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using System.Collections.Generic;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IPayItemsView
    /// </summary>
    public interface IPayItemsView : IView
    {
        /// <summary>
        /// Gets or sets the pay items.
        /// </summary>
        /// <value>
        /// The pay items.
        /// </value>
        IList<PayItemModel> PayItems { set; }
    }
}

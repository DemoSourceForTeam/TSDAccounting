

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IInventoryItemsView
    /// </summary>
    public interface IInventoryItemsView : IView
    {
        /// <summary>
        /// Sets the inventory items.
        /// </summary>
        /// <value>The inventory items.</value>
        IList<InventoryItemModel> InventoryItems { set; }
    }
}

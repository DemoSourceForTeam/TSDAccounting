

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Inventory;


namespace TSD.AccountingSoft.View.Inventory
{
    /// <summary>
    /// interface IItemTransactionsView  
    /// </summary>
    public interface IItemTransactionsView   
    {
        /// <summary>
        /// Sets the ItemTransaction vouchers.
        /// </summary>
        /// <value>
        /// The ItemTransaction vouchers.
        /// </value>
        IList<ItemTransactionModel> ItemTransactions { set; }

        IList<ItemTransactionDetailModel> ItemTransactionDetails { set; } 
    }
}



using System;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class InventoryItemRequest.
    /// </summary>
    public class InventoryItemRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the stock identifier.
        /// </summary>
        /// <value>The StockId.</value>
        public int InventoryItemId { get; set; }

        /// <summary>
        /// Gets or sets the post date.
        /// </summary>
        /// <value>
        /// The post date.
        /// </value>
        public DateTime PostDate { get; set; }

        /// <summary>
        /// Gets or sets the item stock identifier.
        /// </summary>
        /// <value>
        /// The item stock identifier.
        /// </value>
        public int ItemStockId { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        public string CurrencyCode { get; set; }

        public long RefId { get; set; }

        /// <summary>
        /// The InventoryItem
        /// </summary>
        public InventoryItemEntity InventoryItem;
    }
}

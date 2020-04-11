

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// class InventoryItemResponse
    /// </summary>
    public class InventoryItemResponse :ResponseBase
    {
        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int InventoryItemId { get; set; }

        /// <summary>
        /// The customer
        /// </summary>
        public InventoryItemEntity InventoryItem;

        /// <summary>
        /// The customers
        /// </summary>
        public List<InventoryItemEntity> InventoryItems;

    }
}

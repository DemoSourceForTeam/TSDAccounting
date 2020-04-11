

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// PayItemRequest
    /// </summary>
    public class PayItemRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the pay item identifier.
        /// </summary>
        /// <value>
        /// The pay item identifier.
        /// </value>
        public int PayItemId { get; set; }

        /// <summary>
        /// The pay item
        /// </summary>
        public PayItemEntity PayItem;
    }
}

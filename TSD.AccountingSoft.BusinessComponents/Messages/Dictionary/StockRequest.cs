

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class StockRequest.
    /// </summary>
    public class StockRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the Stock identifier.
        /// </summary>
        /// <value>
        /// The Stock identifier.
        /// </value>
        public int StockId { get; set; }

        /// <summary>
        /// The Stock
        /// </summary>
        public StockEntity Stock;
    }
}

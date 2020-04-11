

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class StockResponse.
    /// </summary>
    public class StockResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int StockId { get; set; }

        /// <summary>
        /// The customer
        /// </summary>
        public StockEntity Stock;

        /// <summary>
        /// The customers
        /// </summary>
        public List<StockEntity> Stocks;
    }
}

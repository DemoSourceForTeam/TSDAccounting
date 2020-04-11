

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class CurrencyResponse.
    /// </summary>
    public class CurrencyResponse: ResponseBase 
    {
        /// <summary>
        /// The currencies
        /// </summary>
        public IList<CurrencyEntity> Currencies;

        /// <summary>
        /// The currency
        /// </summary>
        public CurrencyEntity Currency;

        /// <summary>
        /// Gets or sets the Currency identifier.
        /// </summary>
        /// <value>The Currency identifier.</value>
        public int CurrencyId { get; set; } 
    }
}

﻿

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{

    /// <summary>
    /// ExchangeRateResponse
    /// </summary>
    public class ExchangeRateResponse : ResponseBase
    {

        /// <summary>
        /// The exchange rates
        /// </summary>
        public IList<ExchangeRateEntity> ExchangeRates;

        /// <summary>
        /// The exchange rate
        /// </summary>
        public ExchangeRateEntity ExchangeRate;

        /// <summary>
        /// Gets or sets the exchange rate identifier.
        /// </summary>
        /// <value>
        /// The exchange rate identifier.
        /// </value>
        public int ExchangeRateId { get; set; }
    }
}

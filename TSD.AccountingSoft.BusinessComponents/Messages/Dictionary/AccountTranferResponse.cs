﻿

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// AccountTranferResponse
    /// </summary>
    public class AccountTranferResponse : ResponseBase
    {
        /// <summary>
        /// The account tranfers
        /// </summary>
        public IList<AccountTranferEntity> AccountTranfers;

        /// <summary>
        /// The account tranfer
        /// </summary>
        public AccountTranferEntity AccountTranfer;

        /// <summary>
        /// Gets or sets the account tranfer identifier.
        /// </summary>
        /// <value>
        /// The account tranfer identifier.
        /// </value>
        public int AccountTranferId { get; set; }
    }
}

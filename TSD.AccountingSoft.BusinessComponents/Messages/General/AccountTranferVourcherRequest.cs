

using System;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.General;


namespace TSD.AccountingSoft.BusinessComponents.Messages.General
{
    /// <summary>
    /// Class AccountTranferVourcherRequest.
    /// </summary>
    public class AccountTranferVourcherRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the reference identifier.
        /// </summary>
        /// <value>The reference identifier.</value>
        public long RefId { get; set; }

        /// <summary>
        /// Gets or sets the general entity.
        /// </summary>
        /// <value>The general entity.</value>
        public AccountTranferVourcherEntity AccountTranferVourcherEntity { get; set; }

        /// <summary>
        /// From date
        /// </summary>
        public DateTime PostedDate;

        /// <summary>
        /// The currency code
        /// </summary>
        public string CurrencyCode;

        /// <summary>
        /// The reference type identifier
        /// </summary>
        public int RefTypeId;
    }
}

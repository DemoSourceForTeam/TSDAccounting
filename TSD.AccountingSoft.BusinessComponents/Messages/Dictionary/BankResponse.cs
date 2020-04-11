

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// BankResponse
    /// </summary>
    public class BankResponse : ResponseBase
    {
        /// <summary>
        /// The banks
        /// </summary>
        public IList<BankEntity> Banks;

        /// <summary>
        /// The bank
        /// </summary>
        public BankEntity Bank;

        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public int BankId { get; set; }
    }
}

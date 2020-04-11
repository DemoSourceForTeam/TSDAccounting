

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// BankRequest
    /// </summary>
    public class BankRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public int BankId { get; set; }

        /// <summary>
        /// The bank
        /// </summary>
        public BankEntity Bank;
    }
}

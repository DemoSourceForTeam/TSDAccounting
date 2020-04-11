

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// AccountTranferRequest
    /// </summary>
    public class AccountTranferRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the account tranfer identifier.
        /// </summary>
        /// <value>
        /// The account tranfer identifier.
        /// </value>
        public int AccountTranferId { get; set; }

        /// <summary>
        /// The account tranfer
        /// </summary>
        public AccountTranferEntity AccountTranfer;
    }
}

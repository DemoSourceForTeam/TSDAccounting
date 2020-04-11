

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class AccountResponse.
    /// </summary>
    public class AccountResponse : ResponseBase
    {
        /// <summary>
        /// The accounts
        /// </summary>
        public IList<AccountEntity> Accounts;

        /// <summary>
        /// The account
        /// </summary>
        public AccountEntity Account;

        /// <summary>
        /// The account identifier
        /// </summary>
        public int AccountId;
    }
}

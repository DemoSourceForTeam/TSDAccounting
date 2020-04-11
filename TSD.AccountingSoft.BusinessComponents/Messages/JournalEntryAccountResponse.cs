

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business;


namespace TSD.AccountingSoft.BusinessComponents.Messages
{
    /// <summary>
    /// JournalEntryAccountResponse
    /// </summary>
    public class JournalEntryAccountResponse : ResponseBase
    {
        /// <summary>
        /// The journal entry accounts
        /// </summary>
        public IList<JournalEntryAccountEntity> JournalEntryAccounts;

        /// <summary>
        /// The journal entry account
        /// </summary>
        public JournalEntryAccountEntity JournalEntryAccount;

        /// <summary>
        /// The journal entry identifier
        /// </summary>
        public long JournalEntryId;
    }
}

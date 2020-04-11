

using System;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business;


namespace TSD.AccountingSoft.BusinessComponents.Messages
{
    /// <summary>
    /// class JournalEntryAccountRequest
    /// </summary>
    public class JournalEntryAccountRequest : RequestBase
    {
        /// <summary>
        /// The journal entry account
        /// </summary>
        public JournalEntryAccountEntity JournalEntryAccount;

        /// <summary>
        /// From date
        /// </summary>
        public DateTime FromDate;

        /// <summary>
        /// To date
        /// </summary>
        public DateTime ToDate;

        /// <summary>
        /// The export type
        /// </summary>
        public int ExportType;
    }
}

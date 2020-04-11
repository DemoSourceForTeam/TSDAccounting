﻿

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.Opening;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Opening
{
    /// <summary>
    /// OpeningAccountEntryResponse
    /// </summary>
    public class OpeningInventoryEntryResponse : ResponseBase 
    {
        /// <summary>
        /// The opening account entries
        /// </summary>
        public IList<OpeningInventoryEntryEntity> OpeningInventoryEntries; 

        /// <summary>
        /// The opening account entry
        /// </summary>
        public OpeningInventoryEntryEntity OpeningInventoryEntry;

        /// <summary>
        /// The reference identifier
        /// </summary>
        public long RefId;
    }
}
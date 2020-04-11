

using TSD.AccountingSoft.BusinessEntities.Business.Opening;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;

namespace TSD.AccountingSoft.BusinessComponents.Message.Opening
{
    /// <summary>
    /// Class OpeningSupplyEntryResponse.
    /// </summary>
    /// <seealso cref="ResponseBase" />
    public class OpeningSupplyEntryResponse : ResponseBase
    {
        public OpeningSupplyEntryEntity OpeningSupplyEntry { get; set; }

        public long RefId { get; set; }
    }
}

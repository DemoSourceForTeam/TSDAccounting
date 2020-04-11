

using System;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.System;


namespace TSD.AccountingSoft.BusinessComponents.Messages.System
{
    /// <summary>
    /// class SiteRequest 
    /// </summary>
    public class LockRequest : RequestBase
    {
        public LockEntity Lock;

        public int RefId;

        public int RefTypeId;

        public DateTime RefDate;


    }
}

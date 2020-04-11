

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    public class AutoNumberListResponse : ResponseBase
    {
        public IList<AutoNumberListEntity> AutoNumberLists;

        public AutoNumberListEntity AutoNumberList;
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    public class AutoNumberListRequest : RequestBase
    {

        public string  TableCode { get; set; }

        public AutoNumberListEntity AutoNumberList;

        public IList<AutoNumberListEntity> AutoNumberLists;


    }
}

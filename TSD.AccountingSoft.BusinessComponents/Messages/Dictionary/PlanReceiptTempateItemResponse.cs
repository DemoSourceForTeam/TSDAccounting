

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// PlanReceiptTempateItemResponse
    /// </summary>
    public class PlanReceiptTempateItemResponse : ResponseBase
    {
        /// <summary>
        /// The plan receipt tempate items
        /// </summary>
        public IList<PlanReceiptTempateItemEntity> PlanReceiptTempateItems;

        /// <summary>
        /// The plan receipt tempate item
        /// </summary>
        public PlanReceiptTempateItemEntity PlanReceiptTempateItem;
    }
}

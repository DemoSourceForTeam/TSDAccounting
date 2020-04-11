

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class PlanTemplateItemResponse.
    /// </summary>
    public class PlanTemplateItemResponse : ResponseBase
    {
        /// <summary>
        /// The budget item
        /// </summary>
        public IList<PlanTemplateItemEntity> PlanTemplateItems;

        /// <summary>
        /// The budget item
        /// </summary>
        public PlanTemplateItemEntity PlanTemplateItem;

        /// <summary>
        /// The budget item identifier
        /// </summary>
        public int PlanTemplateItemId;
    }
}

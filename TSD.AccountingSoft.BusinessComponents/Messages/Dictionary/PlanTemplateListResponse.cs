

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class PlanTemplateListResponse.
    /// </summary>
    public class PlanTemplateListResponse : ResponseBase
    {
        /// <summary>
        /// The budget item
        /// </summary>
        public IList<PlanTemplateListEntity> PlanTemplateLists;

        /// <summary>
        /// The budget item
        /// </summary>
        public PlanTemplateListEntity PlanTemplateList;

        /// <summary>
        /// The budget item identifier
        /// </summary>
        public int PlanTemplateListId;
    }
}

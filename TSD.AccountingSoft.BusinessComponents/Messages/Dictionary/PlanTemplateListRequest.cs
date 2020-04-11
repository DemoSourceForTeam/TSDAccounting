﻿

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class PlanTemplateListRequest.
    /// </summary>
    public class PlanTemplateListRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the plan template list identifier.
        /// </summary>
        /// <value>The plan template list identifier.</value>
        public int PlanTemplateListId { get; set; }

        /// <summary>
        /// The budget item
        /// </summary>
        public PlanTemplateListEntity PlanTemplateList;

        /// <summary>
        /// Gets or sets the is receipt.
        /// </summary>
        /// <value>The is receipt.</value>
        public int IsReceipt { get; set; }
    }
}

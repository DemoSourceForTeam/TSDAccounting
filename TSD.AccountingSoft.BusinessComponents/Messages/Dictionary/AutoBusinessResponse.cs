

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// AutoBusinessResponse
    /// </summary>
   public class AutoBusinessResponse : ResponseBase
    {
        /// <summary>
        /// The automatic businesses
        /// </summary>
        public IList<AutoBusinessEntity> AutoBusinesses;

        /// <summary>
        /// The autoBusiness
        /// </summary>
        public AutoBusinessEntity AutoBusiness;

        /// <summary>
        /// Gets or sets the autoBusiness identifier.
        /// </summary>
        /// <value>
        /// The autoBusiness identifier.
        /// </value>
        public int AutoBusinessId { get; set; }
    }
}

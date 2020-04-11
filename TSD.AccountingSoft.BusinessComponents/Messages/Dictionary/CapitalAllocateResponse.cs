

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class CapitalAllocateResponse.
    /// </summary>
    public class CapitalAllocateResponse: ResponseBase  
    {
        /// <summary>
        /// The budget source properties
        /// </summary>
        public IList<CapitalAllocateEntity> CapitalAllocates;

        /// <summary>
        /// The CapitalAllocate
        /// </summary>
        public CapitalAllocateEntity CapitalAllocate;

        /// <summary>
        /// Gets or sets the CapitalAllocate identifier.
        /// </summary>
        /// <value>The CapitalAllocate identifier.</value>
        public int CapitalAllocateId { get; set; } 
    }
}

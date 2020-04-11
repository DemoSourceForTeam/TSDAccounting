

using System;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class CapitalAllocateRequest.
    /// </summary>
    public class CapitalAllocateRequest : RequestBase 
    {
        /// <summary>
        /// Gets or sets the CapitalAllocate identifier.
        /// </summary>
        /// <value>The CapitalAllocate identifier.</value>
        public int CapitalAllocateId { get; set; }

        /// <summary>
        /// The CapitalAllocate
        /// </summary>
        public CapitalAllocateEntity CapitalAllocate;

        /// <summary>
        /// The CapitalAllocate
        /// </summary>
        public DateTime  FromDate; 

        /// <summary>
        /// The CapitalAllocate
        /// </summary>
        public DateTime ToDate;   


    }
}

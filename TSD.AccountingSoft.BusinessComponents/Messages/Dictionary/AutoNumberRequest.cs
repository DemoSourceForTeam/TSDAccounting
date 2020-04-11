

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// AutoNumberRequest
    /// </summary>
    public class AutoNumberRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the reference type identifier.
        /// </summary>
        /// <value>
        /// The reference type identifier.
        /// </value>
        public int RefTypeId { get; set; }

        /// <summary>
        /// The automatic number
        /// </summary>
        public AutoNumberEntity AutoNumber;

        /// <summary>
        /// The automatic numbers
        /// </summary>
        public IList<AutoNumberEntity> AutoNumbers;
    }
}


using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// AutoNumberResponse
    /// </summary>
    public class AutoNumberResponse : ResponseBase
    {
        /// <summary>
        /// The automatic numbers
        /// </summary>
        public IList<AutoNumberEntity> AutoNumbers;

        /// <summary>
        /// The automatic number
        /// </summary>
        public AutoNumberEntity AutoNumber;
    }
}

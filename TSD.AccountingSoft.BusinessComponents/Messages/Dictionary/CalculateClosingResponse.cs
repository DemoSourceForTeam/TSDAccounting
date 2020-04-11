


using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// CaculateClosingResponse
    /// </summary>
    public class CaculateClosingResponse : ResponseBase
    {
        /// <summary>
        /// The Calculate Closings
        /// </summary>
        public IList<CalculateClosingEntity> CalculateClosings;

        /// <summary>
        /// The Calculate Closing Entity
        /// </summary>
        public CalculateClosingEntity CalculateClosing;
    }
}

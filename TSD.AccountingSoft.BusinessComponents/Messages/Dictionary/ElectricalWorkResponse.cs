

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class StockResponse.
    /// </summary>
    public class ElectrialWorkResponse : ResponseBase
    {

        public int ElectrialWorkId { get; set; }

        public ElectricalWorkEntity ElectricalWorkEntity;

    }
}

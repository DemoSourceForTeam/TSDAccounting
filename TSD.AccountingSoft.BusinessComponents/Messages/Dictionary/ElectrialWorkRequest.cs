

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class ElectrialWorkRequest.
    /// </summary>
    public class ElectrialWorkRequest : RequestBase
    {
        public int PostedDate { get; set; }

        public ElectricalWorkEntity ElectricalWorkEntity;
    }
}



using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// BuildingRequest
    /// </summary>
    public class MutualRequest : RequestBase
    {
        public int MutualId;
        public string  MutualCode;
        public MutualEntity Mutual;
    }
}

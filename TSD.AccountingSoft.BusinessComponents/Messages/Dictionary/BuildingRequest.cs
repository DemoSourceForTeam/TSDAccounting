

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// BuildingRequest
    /// </summary>
    public class BuildingRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the employeeLeasing identifier.
        /// </summary>
        /// <value>
        /// The employeeLeasing identifier.
        /// </value>
        public int BuildingId;

        /// <summary>
        /// The employeeLeasing
        /// </summary>
        public BuildingEntity Building;
    }
}



using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// AudittingLogRequest
    /// </summary>
    public class AudittingLogRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        /// <value>
        /// The event identifier.
        /// </value>
        public int EventId { get; set; }

        /// <summary>
        /// The auditting log
        /// </summary>
        public AudittingLogEntity AudittingLog;
    }
}

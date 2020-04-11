

namespace TSD.AccountingSoft.BusinessComponents.Messages.MessageBase
{
    /// <summary>
    /// class ResponseBase
    /// </summary>
    public class ResponseBase
    {
        /// <summary>
        /// The message
        /// </summary>
        public string Message;

        /// <summary>
        /// The acknowledge
        /// </summary>
        public AcknowledgeType Acknowledge = AcknowledgeType.Success;

        /// <summary>
        /// The rows affected
        /// </summary>
        public int RowsAffected;
    }
}
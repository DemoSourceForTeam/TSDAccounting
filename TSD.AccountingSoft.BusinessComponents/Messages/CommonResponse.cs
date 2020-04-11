
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;

namespace TSD.AccountingSoft.BusinessComponents.Messages
{
    /// <summary>
    /// class CommonResponse
    /// </summary>
    public class CommonResponse : ResponseBase
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public int? Id;

        /// <summary>
        /// The reset increment success
        /// </summary>
        public bool ResetIncrementSuccess;
    }
}

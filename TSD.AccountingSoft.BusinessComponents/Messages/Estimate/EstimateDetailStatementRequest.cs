

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Report.Estimate;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Estimate
{
    /// <summary>
    /// EstimateDetailStatementRequest
    /// </summary>
    public class EstimateDetailStatementRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public int EstimateDetailStatementId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is active].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is active]; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// The bank
        /// </summary>
        public EstimateDetailStatementInfoEntity EstimateDetailStatement;
    }
}

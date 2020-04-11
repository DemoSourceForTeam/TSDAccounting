

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class MergerFundRequest.
    /// </summary>
    public class MergerFundRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the merger fund identifier.
        /// </summary>
        /// <value>The merger fund identifier.</value>
        public int MergerFundId { get; set; }

        /// <summary>
        /// The merger fund
        /// </summary>
        public MergerFundEntity MergerFund;
    }
}

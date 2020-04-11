

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.Estimate;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Estimate
{
    /// <summary>
    /// Class EstimateResponse.
    /// </summary>
    public class EstimateResponse : ResponseBase
    {
        /// <summary>
        /// The estimates
        /// </summary>
        public IList<EstimateEntity> Estimates;

        /// <summary>
        /// The estimate
        /// </summary>
        public EstimateEntity Estimate;

        /// <summary>
        /// The reference identifier
        /// </summary>
        public long RefId;
    }
}

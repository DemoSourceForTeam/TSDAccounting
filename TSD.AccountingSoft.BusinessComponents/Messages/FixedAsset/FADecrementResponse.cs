

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.FixedAssetDecrement;


namespace TSD.AccountingSoft.BusinessComponents.Messages.FixedAsset
{
    /// <summary>
    /// class FADecrementResponse
    /// </summary>
    public class FADecrementResponse: ResponseBase
    {
        /// <summary>
        /// The fAArmortizations
        /// </summary>
        public IList<FADecrementEntity> FADecrements;

        /// <summary>
        /// The fAArmortizations
        /// </summary>
        public IList<FADecrementDetailEntity> FADecrementDetails;
        /// <summary>
        /// The fAArmortization
        /// </summary>
        public FADecrementEntity FADecrement;

        /// <summary>
        /// The reference identifier
        /// </summary>
        public long RefId;
    }
}

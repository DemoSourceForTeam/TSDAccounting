

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.FixedAssetIncrement;


namespace TSD.AccountingSoft.BusinessComponents.Messages.FixedAsset
{
    /// <summary>
    /// FAIncrementResponse
    /// </summary>
    public class FAIncrementResponse : ResponseBase
    {
        /// <summary>
        /// The fAIncrements
        /// </summary>
        public IList<FAIncrementEntity> FAIncrements;

        /// <summary>
        /// The fAIncrement
        /// </summary>
        public FAIncrementEntity FAIncrement;

        /// <summary>
        /// The reference identifier
        /// </summary>
        public long RefId;
    }
}

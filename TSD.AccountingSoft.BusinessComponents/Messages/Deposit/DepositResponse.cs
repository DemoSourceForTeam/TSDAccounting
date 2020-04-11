

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.Deposit;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Deposit
{
    /// <summary>
    /// Class DepositResponse.
    /// </summary>
    public class DepositResponse : ResponseBase
    {
        /// <summary>
        /// The estimates
        /// </summary>
        public IList<DepositEntity> Deposits;

        /// <summary>
        /// The estimate
        /// </summary>
        public DepositEntity Deposit;

        /// <summary>
        /// The reference identifier
        /// </summary>
        public long RefId;
    }
}

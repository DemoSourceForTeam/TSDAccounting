

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.General;


namespace TSD.AccountingSoft.BusinessComponents.Messages.General
{
    /// <summary>
    /// AccountTranferVoucherReponse
    /// </summary>
    public class AccountTranferVourcherReponse : ResponseBase
    {

        /// <summary>
        /// The get account tranfer vourchers
        /// </summary>
        public IList<AccountTranferVourcherEntity> GetAccountTranferVourchers;

        /// <summary>
        /// The reference detail
        /// </summary>
        public long  RefDetailId;

        /// <summary>
        /// The reference identifier
        /// </summary>
        public long RefId;

        /// <summary>
        /// The account tranfer vourcher
        /// </summary>
        public AccountTranferVourcherEntity AccountTranferVourcher;
    }
}

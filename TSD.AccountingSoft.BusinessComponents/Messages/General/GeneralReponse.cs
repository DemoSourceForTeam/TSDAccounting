

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Business.General;


namespace TSD.AccountingSoft.BusinessComponents.Messages.General
{
    /// <summary>
    /// Class GeneralReponse.
    /// </summary>
 public   class GeneralReponse : ResponseBase
    {

        /// <summary>
        /// The receipt vouchers
        /// </summary>
        public IList<GeneralEntity> Generals;

        /// <summary>
        /// The receipt voucher
        /// </summary>
        public GeneralEntity General;

        /// <summary>
        /// The cash detail
        /// </summary>
        public GeneralDetailEntity GeneralDetail;

        /// <summary>
        /// The reference identifier
        /// </summary>
        public long RefId; 


    }
}

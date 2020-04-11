

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// 
    /// </summary>
    public class VoucherTypeRequest : RequestBase
    {
        /// <summary>
        /// The voucherTypes
        /// </summary>
        public IList<VoucherTypeEntity> VoucherTypes;

        /// <summary>
        /// The voucherType
        /// </summary>
        public VoucherTypeEntity VoucherType;

        /// <summary>
        /// Gets or sets the voucherType identifier.
        /// </summary>
        /// <value>
        /// The voucherType identifier.
        /// </value>
        public int VoucherTypeId { get; set; }

        public string Code { get; set; }
    }
}

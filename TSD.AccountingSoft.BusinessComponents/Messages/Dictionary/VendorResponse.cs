

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// VendorResponse class
    /// </summary>
    public class VendorResponse: ResponseBase
    {
        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int VendorId { get; set; }

        /// <summary>
        /// The vendor
        /// </summary>
        public VendorEntity Vendor;

        /// <summary>
        /// The vendors
        /// </summary>
        public List<VendorEntity> Vendors;
    }
}



namespace TSD.AccountingSoft.Model.BusinessObjects.Dictionary
{
    /// <summary>
    /// VoucherTypeModel
    /// </summary>
    public class VoucherTypeModel
    {
        /// <summary>
        /// Gets or sets the voucher type identifier.
        /// </summary>
        /// <value>
        /// The voucher type identifier.
        /// </value>
        public int VoucherTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the voucher type.
        /// </summary>
        /// <value>
        /// The name of the voucher type.
        /// </value>
        public string VoucherTypeName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is active].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is active]; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }
    }
}

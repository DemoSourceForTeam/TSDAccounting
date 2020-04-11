

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// class FixedAssetCategoryRequest
    /// </summary>
    public class FixedAssetCategoryRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the fixed asset identifier.
        /// </summary>
        /// <value>
        /// The fixed asset identifier.
        /// </value>
        public int FixedAssetCategoryId { get; set; }

        /// <summary>
        /// The fixed asset
        /// </summary>
        public FixedAssetCategoryEntity FixedAssetCategory;
    }
}

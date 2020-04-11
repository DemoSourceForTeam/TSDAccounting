
namespace TSD.AccountingSoft.Model.BusinessObjects.System
{
    /// <summary>
    /// PermissionSiteModel
    /// </summary>
    public class PermissionSiteModel
    {
        /// <summary>
        /// Gets or sets the permission site identifier.
        /// </summary>
        /// <value>
        /// The permission site identifier.
        /// </value>
        public int PermissionSiteId { get; set; }

        /// <summary>
        /// Gets or sets the site identifier.
        /// </summary>
        /// <value>
        /// The site identifier.
        /// </value>
        public int SiteId { get; set; }

        /// <summary>
        /// Gets or sets the permission identifier.
        /// </summary>
        /// <value>
        /// The permission identifier.
        /// </value>
        public int PermissionId { get; set; }
    }
}

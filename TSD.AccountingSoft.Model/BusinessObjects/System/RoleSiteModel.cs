
namespace TSD.AccountingSoft.Model.BusinessObjects.System
{
    /// <summary>
    /// RoleSiteModel
    /// </summary>
    public class RoleSiteModel
    {
        /// <summary>
        /// Gets or sets the role site identifier.
        /// </summary>
        /// <value>
        /// The role site identifier.
        /// </value>
        public int RoleSiteId { get; set; }

        /// <summary>
        /// Gets or sets the role identifier.
        /// </summary>
        /// <value>
        /// The role identifier.
        /// </value>
        public int RoleId { get; set; }

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
        public int? PermissionId { get; set; }
    }
}

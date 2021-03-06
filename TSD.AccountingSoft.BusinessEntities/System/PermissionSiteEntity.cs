﻿

namespace TSD.AccountingSoft.BusinessEntities.System
{
    /// <summary>
    /// PermissionSiteEntity
    /// </summary>
    public class PermissionSiteEntity : BusinessEntities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionSiteEntity"/> class.
        /// </summary>
        public PermissionSiteEntity()
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionSiteEntity"/> class.
        /// </summary>
        /// <param name="permissionSiteId">The permission site identifier.</param>
        /// <param name="siteId">The site identifier.</param>
        /// <param name="permissionId">The permission identifier.</param>
        public PermissionSiteEntity(int permissionSiteId, int siteId, int permissionId)
            : this()
        {
            PermissionSiteId = permissionSiteId;
            SiteId = siteId;
            PermissionId = permissionId;
        }

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

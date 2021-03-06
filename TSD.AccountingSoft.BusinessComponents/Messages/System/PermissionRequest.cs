﻿

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.System;


namespace TSD.AccountingSoft.BusinessComponents.Messages.System
{
    /// <summary>
    /// class PermissionRequest
    /// </summary>
    public class PermissionRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the role identifier.
        /// </summary>
        /// <value>
        /// The role identifier.
        /// </value>
        public int PermissionId { get; set; }

        /// <summary>
        /// The role
        /// </summary>
        public PermissionEntity Permission;

        /// <summary>
        /// Gets or sets a value indicating whether [is active].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is active]; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }
    }
}

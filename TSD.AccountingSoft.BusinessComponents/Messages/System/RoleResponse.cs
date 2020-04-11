

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.System;


namespace TSD.AccountingSoft.BusinessComponents.Messages.System
{
    /// <summary>
    /// RoleResponse
    /// </summary>
    public class RoleResponse : ResponseBase
    {
        /// <summary>
        /// The roles
        /// </summary>
        public IList<RoleEntity> Roles;

        /// <summary>
        /// The role
        /// </summary>
        public RoleEntity Role;

        /// <summary>
        /// Gets or sets the role identifier.
        /// </summary>
        /// <value>
        /// The role identifier.
        /// </value>
        public int RoleId { get; set; }
    }
}

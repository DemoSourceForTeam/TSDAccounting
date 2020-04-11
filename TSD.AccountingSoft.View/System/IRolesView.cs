

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.System;


namespace TSD.AccountingSoft.View.System
{
    /// <summary>
    /// IRolesView
    /// </summary>
    public interface IRolesView : IView
    {
        /// <summary>
        /// Sets the roles.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        IList<RoleModel> Roles { set; }
    }
}

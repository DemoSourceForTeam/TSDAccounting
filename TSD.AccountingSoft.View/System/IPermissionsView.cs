

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.System;


namespace TSD.AccountingSoft.View.System
{
    /// <summary>
    /// IPermissionsView
    /// </summary>
    public interface IPermissionsView : IView
    {
        /// <summary>
        /// Sets the permissions.
        /// </summary>
        /// <value>
        /// The permissions.
        /// </value>
        IList<PermissionModel> Permissions { set; }
    }
}

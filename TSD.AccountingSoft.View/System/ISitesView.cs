

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.System;


namespace TSD.AccountingSoft.View.System
{
    /// <summary>
    /// interface ISitesView
    /// </summary>
    public interface ISitesView
    {
        /// <summary>
        /// Sets the sites.
        /// </summary>
        /// <value>
        /// The sites.
        /// </value>
        IList<SiteModel> Sites { set; }
    }
}

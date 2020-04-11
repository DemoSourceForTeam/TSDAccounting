

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.System;


namespace TSD.AccountingSoft.BusinessComponents.Messages.System
{
    /// <summary>
    /// SiteResponse
    /// </summary>
    public class SiteResponse : ResponseBase
    {
        /// <summary>
        /// The sites
        /// </summary>
        public IList<SiteEntity> Sites;

        /// <summary>
        /// The site
        /// </summary>
        public SiteEntity Site;

        /// <summary>
        /// Gets or sets the site identifier.
        /// </summary>
        /// <value>
        /// The site identifier.
        /// </value>
        public int SiteId { get; set; }
    }
}

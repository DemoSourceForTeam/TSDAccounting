

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// ProjectRequest
    /// </summary>
    public class ProjectRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        public int ProjectId { get; set; }

        /// <summary>
        /// The project
        /// </summary>
        public ProjectEntity Project;
    }
}

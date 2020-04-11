

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// class ProjectResponse
    /// </summary>
    public class ProjectResponse : ResponseBase
    {
        /// <summary>
        /// The projects
        /// </summary>
        public IList<ProjectEntity> Projects;

        /// <summary>
        /// The project
        /// </summary>
        public ProjectEntity Project;

        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        public int ProjectId { get; set; }
    }
}

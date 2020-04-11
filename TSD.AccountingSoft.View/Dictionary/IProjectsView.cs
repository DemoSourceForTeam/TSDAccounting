

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// interface IProjectsView
    /// </summary>
    public interface IProjectsView
    {
        /// <summary>
        /// Sets the projects.
        /// </summary>
        /// <value>
        /// The projects.
        /// </value>
        IList<ProjectModel> Projects { set; }
    }
}

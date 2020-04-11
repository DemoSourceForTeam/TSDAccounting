

using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using TSD.AccountingSoft.View.Dictionary;
using System.Collections.Generic;

namespace TSD.AccountingSoft.Presenter.Dictionary.Project
{
    /// <summary>
    /// class ProjectsPresenter
    /// </summary>
    public class ProjectsPresenter : Presenter<IProjectsView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public ProjectsPresenter(IProjectsView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
       
            View.Projects = Model.GetProjects(); 
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void DisplayActive()
        {
            
            View.Projects = Model.GetProjectsActive() ;
        }

        /// <summary>
        /// Displays the non active.
        /// </summary>
        public void DisplayNonActive()
        {
            View.Projects = Model.GetProjectsNonActive() ;
        }
    }
}



using TSD.AccountingSoft.View.System;


namespace TSD.AccountingSoft.Presenter.System.Site
{
    /// <summary>
    /// SitesPresenter
    /// </summary>
    public class SitesPresenter : Presenter<ISitesView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitesPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public SitesPresenter(ISitesView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.Sites = Model.GetSites();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void Display(bool isActive)
        {
            View.Sites = Model.GetSites(isActive);
        }
    }
}

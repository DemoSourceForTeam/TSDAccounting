

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.AutoBusiness
{
    /// <summary>
    /// AutoBusinessesPresenter
    /// </summary>
    public class AutoBusinessesPresenter: Presenter<IAutoBusinessesView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoBusinessesPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public AutoBusinessesPresenter(IAutoBusinessesView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.AutoBusinesses = Model.GetAutoBusinesss();
        }

        public void Display(int refTypeId, bool isActive)
        {
            View.AutoBusinesses = Model.GetAutoBusinessByRefType(refTypeId, isActive);
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void DisplayActive()
        {
            View.AutoBusinesses = Model.GetAutoBusinesssActive();
        }
    }
}

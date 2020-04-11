

using TSD.AccountingSoft.View.Dictionary;

namespace TSD.AccountingSoft.Presenter.Dictionary.CompanyProfile
{
    /// <summary>
    /// BanksPresenter
    /// </summary>
    public class CompanyProfilesPresenter : Presenter<IBanksView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyProfilesPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public CompanyProfilesPresenter(IBanksView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.Banks = Model.GetBanks();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void DisplayActive()
        {
            View.Banks = Model.GetBanksActive();
        }
    }
}



using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.AccountTranfer
{
    /// <summary>
    /// AccountTranfersPresenter
    /// </summary>
    public class AccountTranfersPresenter : Presenter<IAccountTranfersView>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTranfersPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public AccountTranfersPresenter(IAccountTranfersView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.AccountTranfers = Model.GetAccountTranfers();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void DisplayActive()
        {
            View.AccountTranfers = Model.GetAccountTranfersActive();
        }
    }
}

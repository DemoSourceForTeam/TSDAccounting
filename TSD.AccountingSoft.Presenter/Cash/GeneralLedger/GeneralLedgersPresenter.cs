

using TSD.AccountingSoft.View.Cash;


namespace TSD.AccountingSoft.Presenter.Cash.GeneralLedger
{
    /// <summary>
    /// class GeneralLedgersPresenter
    /// </summary>
    public class GeneralLedgersPresenter : Presenter<IGeneralLedgersView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgersPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public GeneralLedgersPresenter(IGeneralLedgersView view)
            : base(view)
        {
        }
    }
}

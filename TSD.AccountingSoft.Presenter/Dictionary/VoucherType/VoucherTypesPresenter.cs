

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.VoucherType
{
    /// <summary>
    /// class VoucherTypesPresenter
    /// </summary>
    public class VoucherTypesPresenter : Presenter<IVoucherTypesView>
    {
        /// <summary>
        /// VoucherTypets the presenter.
        /// </summary>
        /// <param name="view">The view.</param>
        public VoucherTypesPresenter(IVoucherTypesView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.VoucherTypes = Model.GetVoucherTypes();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void DisplayActive()
        {
            View.VoucherTypes = Model.GetVoucherTypesActive();
        }
    }
}

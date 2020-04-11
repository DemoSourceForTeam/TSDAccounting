

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.VoucherList
{

    /// <summary>
    /// VoucherListsPresenter class
    /// </summary>
    public class VoucherListsPresenter : Presenter<IVoucherListsView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherListsPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public VoucherListsPresenter(IVoucherListsView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.VoucherLists = Model.GetVoucherLists();
        }
    }
}

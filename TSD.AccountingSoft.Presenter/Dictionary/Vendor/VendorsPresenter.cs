

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.Vendor
{

    /// <summary>
    /// VendorsPresenter class
    /// </summary>
    public class VendorsPresenter : Presenter<IVendorsView>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="VendorsPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public VendorsPresenter(IVendorsView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.Vendors = Model.GetVendors();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        /// <param name="isActive">if set to <c>true</c> [is active].</param>
        public void DisplayActive(bool isActive)
        {
            View.Vendors = Model.GetVendorsByActive(isActive);
        }
    }
}

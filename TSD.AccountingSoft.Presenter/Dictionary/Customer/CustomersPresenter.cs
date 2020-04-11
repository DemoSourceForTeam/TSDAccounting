

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.Customer
{

    /// <summary>
    /// CustomersPresenter
    /// </summary>
    public class CustomersPresenter : Presenter<ICustomersView>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersPresenter" /> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public CustomersPresenter(ICustomersView view) : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.Customers = Model.GetCustomers();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        /// <param name="isActive">if set to <c>true</c> [is active].</param>
        public void DisplayActive(bool isActive)
        {
            View.Customers = Model.GetCustomersByActive(isActive);
        }        
    }
}

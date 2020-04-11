

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.AccountingObject
{

    /// <summary>
    /// AccountingObjectsPresenter clas
    /// </summary>
    public class AccountingObjectsPresenter : Presenter<IAccountingObjectsView>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingObjectsPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public AccountingObjectsPresenter(IAccountingObjectsView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        
        {
            View.AccountingObjects = Model.GetAccountingObjects();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        /// <param name="isActive">if set to <c>true</c> [is active].</param>
        public void DisplayActive(bool isActive)
        {
            View.AccountingObjects = Model.GetAccountingObjectsByActive(isActive);
        }

        public void DisplayForList()
        {
            View.AccountingObjects = Model.GetAccountingObjectsForList();
        }
    }
}

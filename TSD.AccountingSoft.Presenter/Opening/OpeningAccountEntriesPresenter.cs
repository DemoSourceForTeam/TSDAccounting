

using TSD.AccountingSoft.View.OpeningAccountEntry;


namespace TSD.AccountingSoft.Presenter.Opening
{
    /// <summary>
    /// OpeningAccountEntriesPresenter
    /// </summary>
    public class OpeningAccountEntriesPresenter : Presenter<IOpeningAccountEntriesView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningAccountEntriesPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public OpeningAccountEntriesPresenter(IOpeningAccountEntriesView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.OpeningAccountEntries = Model.GetOpeningAccountEntries();
        }
    }
}

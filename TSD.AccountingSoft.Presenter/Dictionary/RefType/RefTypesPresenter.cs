

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.RefType
{
    public class RefTypesPresenter : Presenter<IRefTypesView>
    {
        /// <summary>
        /// RefTypets the presenter.
        /// </summary>
        /// <param name="view">The view.</param>
        public RefTypesPresenter(IRefTypesView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.RefTypes = Model.GetRefTypes();
        }
    }
}



using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.CalculateClosing
{

    /// <summary>
    /// CalulateClosingsPresenter class
    /// </summary>
    public class CalulateClosingsPresenter : Presenter<ICalculateClosingsView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalulateClosingsPresenter" /> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public CalulateClosingsPresenter(ICalculateClosingsView view)
            : base(view)
        {
        }

    }
}

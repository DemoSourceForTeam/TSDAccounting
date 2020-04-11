

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.CapitalAllocate  
{
    /// <summary>
    /// Class CapitalAllocatesPresenter.
    /// </summary>
    public class CapitalAllocatesPresenter : Presenter<ICapitalAllocatesView> 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalAllocatesPresenter" /> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public CapitalAllocatesPresenter(ICapitalAllocatesView view)  
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.CapitalAllocates = Model.GetCapitalAllocates();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void DisplayActive()
        {
            View.CapitalAllocates = Model.GetCapitalAllocatesActive();
        }
 
    }
}

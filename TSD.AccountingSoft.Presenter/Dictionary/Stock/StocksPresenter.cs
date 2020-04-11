

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.Stock
{
    public class StocksPresenter:Presenter<IStocksView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StocksPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public StocksPresenter(IStocksView view)
            : base(view)
        { 
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.Stocks = Model.GetStocks();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        /// <param name="isActive">if set to <c>true</c> [is active].</param>
        public void DisplayActive(bool isActive)
        {
            View.Stocks = Model.GetStockByActives(isActive);
        } 

    }
}

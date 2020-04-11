

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IStocksView
    /// </summary>
   public interface IStocksView:IView
    {
        /// <summary>
        /// Sets the stocks.
        /// </summary>
        /// <value>The stocks.</value>
        IList<StockModel> Stocks { set; }
    }
}

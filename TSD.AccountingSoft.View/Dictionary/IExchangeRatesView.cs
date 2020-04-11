

using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using System.Collections.Generic;


namespace TSD.AccountingSoft.View.Dictionary
{
    public interface IExchangeRatesView : IView
    {
        /// <summary>
        /// Sets the exchange rate models.
        /// </summary>
        /// <value>
        /// The exchange rate models.
        /// </value>
        IList<ExchangeRateModel> ExchangeRateModels { set; }
    }
}
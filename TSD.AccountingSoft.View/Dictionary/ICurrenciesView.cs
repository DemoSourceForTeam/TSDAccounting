

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface ICurrenciesView
    /// </summary>
    public interface ICurrenciesView : IView 
    {
        /// <summary>
        /// Sets the currencies.
        /// </summary>
        /// <value>The currencies.</value>
        IList<CurrencyModel> Currencies { set; } 
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IAutoBusinessesView
    /// </summary>
    public interface IAutoBusinessesView : IView
    {
        /// <summary>
        /// Sets the automatic businesses.
        /// </summary>
        /// <value>
        /// The automatic businesses.
        /// </value>
        IList<AutoBusinessModel> AutoBusinesses { set; }
    }
}
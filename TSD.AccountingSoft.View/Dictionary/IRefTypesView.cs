

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IRefTypesView
    /// </summary>
    public interface IRefTypesView : IView
    {
        /// <summary>
        /// Sets the reference types.
        /// </summary>
        /// <value>
        /// The reference types.
        /// </value>
        IList<RefTypeModel> RefTypes { set; }
    }
}

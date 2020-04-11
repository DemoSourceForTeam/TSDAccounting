

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface ICapitalAllocatesView
    /// </summary>
    public interface ICapitalAllocatesView : IView  
    {
        /// <summary>
        /// Sets the capital allocates.
        /// </summary>
        /// <value>The capital allocates.</value>
        IList<CapitalAllocateModel> CapitalAllocates { set; }  
    }
}

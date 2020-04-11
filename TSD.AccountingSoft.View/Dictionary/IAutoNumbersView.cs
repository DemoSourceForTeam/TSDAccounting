

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IAutoNumbersView
    /// </summary>
    public interface IAutoNumbersView : IView
    {
        /// <summary>
        /// Gets or sets the automatic numbers.
        /// </summary>
        /// <value>
        /// The automatic numbers.
        /// </value>
        IList<AutoNumberModel> AutoNumbers { get; set; }
    }
}

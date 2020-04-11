


using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// ICalculateClosingsView
    /// </summary>
    public interface ICalculateClosingsView : IView
    {
        /// <summary>
        /// Gets or sets the Calculate Closings.
        /// </summary>
        /// <value>
        /// The Calculate Closings.
        /// </value>
        IList<CalculateClosingModel> CalculateClosings { get; set; }
    }
}

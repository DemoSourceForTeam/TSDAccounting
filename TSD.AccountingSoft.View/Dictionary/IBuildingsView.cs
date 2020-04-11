

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IBuildingsView
    /// </summary>
    public interface IBuildingsView : IView
    {
        /// <summary>
        /// Sets the buildings.
        /// </summary>
        /// <value>
        /// The buildings.
        /// </value>
        IList<BuildingModel> Buildings { set; }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IBuildingsView
    /// </summary>
    public interface IMutualsView : IView
    {

        IList<MutualModel> Mutuals { set; }
    }
}

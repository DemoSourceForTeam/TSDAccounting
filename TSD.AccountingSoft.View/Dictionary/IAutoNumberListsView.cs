

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;

namespace TSD.AccountingSoft.View.Dictionary
{
  public  interface IAutoNumberListsView : IView
    {
       IList<AutoNumberListModel> AutoNumberLists { get; set; }
    }
}

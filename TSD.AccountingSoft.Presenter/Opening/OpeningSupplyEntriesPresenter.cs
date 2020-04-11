

using TSD.AccountingSoft.Model.BusinessObjects.Opening;
using TSD.AccountingSoft.View.OpeningSupplyEntry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.AccountingSoft.Presenter.Opening
{
    public class OpeningSupplyEntriesPresenter : Presenter<IOpeningSupplyEntriesView>
    {
        public OpeningSupplyEntriesPresenter(IOpeningSupplyEntriesView view)
            : base(view)
        {
        }
        public void Display()
        {
            View.OpeningSupplyEntries = Model.GetOpeningSupplyEntry();
        }
        //public void Display(string accountNumber)
        //{
        //    var openingAccountEntries = Model.GetOpeningSupplyEntryEntriesByAccountNumber(accountNumber);
        //    View.OpeningSupplyEntryEntries = openingAccountEntries == null ? new List<OpeningSupplyEntryEntryModel>() : openingAccountEntries;
        //}

        public string Save(IList<OpeningSupplyEntryModel> openingSupplyEntries)
        {
            return Model.UpdateOpeningSupplyEntry(openingSupplyEntries);
        }

        public string Delete(long refId)
        {
            return Model.DeleteOpeningSupplyEntry(refId);
        }
    }
}

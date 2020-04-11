using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages;
using TSD.AccountingSoft.BusinessComponents.Messages.Dictionary;
using TSD.AccountingSoft.DataAccess.IEntitiesDao;


namespace TSD.AccountingSoft.BusinessComponents.Facade
{
    /// <summary>
    /// class JournalEntryAccountFacade
    /// </summary>
    public class JournalEntryAccountFacade
    {
        private static readonly IJournalEntryAccountDao JournalEntryAccountDao = DataAccess.DataAccess.JournalEntryAccountDao;

        public JournalEntryAccountResponse GetJournalEntryAccounts(JournalEntryAccountRequest request)
        {
            var response = new JournalEntryAccountResponse();

            response.JournalEntryAccounts = JournalEntryAccountDao.GetJournalEntryAccounts(request.ExportType, request.FromDate, request.ToDate);
            
            return response;
        }
    }
}

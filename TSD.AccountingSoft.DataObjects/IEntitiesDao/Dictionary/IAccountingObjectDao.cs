

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{
    public interface IAccountingObjectDao
    {
        AccountingObjectEntity GetAccountingObjectById(int accountingObjectId);
        AccountingObjectEntity GetAccountingObjectByCode(string code);
        IList<AccountingObjectEntity> GetAccountingObjects();
        IList<AccountingObjectEntity> GetAccountingObjectByActives(bool isActive);
        IList<AccountingObjectEntity> GetAccountingObjectByCodes(string code);
        IList<AccountingObjectEntity> GetAccountingObjectByAccountingObjectCategoryIds(int categoryId);
        IList<AccountingObjectEntity> GetAccountingObjectsForList();
        int InsertAccountingObject(AccountingObjectEntity accountingObject);
        string UpdateAccountingObject(AccountingObjectEntity accountingObject);
        string DeleteAccountingObject(AccountingObjectEntity accountingObject);
    }    
}

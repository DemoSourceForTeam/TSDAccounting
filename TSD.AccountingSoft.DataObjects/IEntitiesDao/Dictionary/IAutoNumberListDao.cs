

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Dictionary;

namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{
    public interface IAutoNumberListDao
    {

        AutoNumberListEntity GetAutoNumberList(string tableCode);

        List<AutoNumberListEntity> GetAutoNumberLists();

        string UpdateAutoNumberList(AutoNumberListEntity autoNumberList);

        void UpdateIncreateAutoNumberListByValue(string tableCode);

    }
}

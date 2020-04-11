

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{
    /// <summary>
    /// Interface IElectricalWorkDao
    /// </summary>
    public interface IElectricalWorkDao
    {

        ElectricalWorkEntity GetElectricalWork(int yearPosted);
        string UpdateInsertElectricalWork(ElectricalWorkEntity electricalWorkEntity);
    }
}

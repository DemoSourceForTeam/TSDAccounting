

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{
    /// <summary>
    /// IBuildingDao
    /// </summary>
    public interface IMutualDao
    {

        MutualEntity GetMutual(int mutualId);
        List<MutualEntity> GetMutuals();
        List<MutualEntity> GetMutualsByMutualCode(string mutualCode);
        List<MutualEntity> GetMutualsByActive(bool isActive);
        int InsertMutual(MutualEntity mutual);
        string UpdateMutual(MutualEntity mutual);
        string DeleteBuilding(MutualEntity mutual);

        List<MutualEntity> GetMutualsForEstimate(bool isActive);
    }
}

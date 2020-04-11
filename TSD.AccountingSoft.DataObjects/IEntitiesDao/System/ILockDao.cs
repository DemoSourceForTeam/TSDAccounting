

using System;
using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.System;
namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.System
{
    /// <summary>
    /// ISiteDao
    /// </summary>
    public interface ILockDao
    {

        LockEntity GetLock();

        string ExcuteUnLock(LockEntity entity);

        LockEntity CheckLock(int refId, int refTypeId, DateTime refDate);

        LockEntity CheckLock(int refId, int refTypeId);
    }
}

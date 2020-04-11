

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{
    /// <summary>
    /// IAutoNumberDao
    /// </summary>
    public interface IAutoNumberDao
    {
        /// <summary>
        /// Gets the type of the automatic number by reference.
        /// </summary>
        /// <param name="refTypeId">The reference type identifier.</param>
        /// <returns></returns>
        AutoNumberEntity GetAutoNumberByRefType(int refTypeId);

        /// <summary>
        /// Gets the automatic numbers.
        /// </summary>
        /// <returns></returns>
        List<AutoNumberEntity> GetAutoNumbers();

        /// <summary>
        /// Updates the automatic number.
        /// </summary>
        /// <param name="autoNumber">The automatic number.</param>
        /// <returns></returns>
        string UpdateAutoNumber(AutoNumberEntity autoNumber);

        AutoNumberEntity GetAutoNumberByRefTypeSalary(int refTypeId,string currDate);

    }
}

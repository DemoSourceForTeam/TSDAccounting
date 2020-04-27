

using System.Collections.Generic;
using System.Collections.ObjectModel;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{
    /// <summary>
    /// IRefTypeDao
    /// </summary>
    public interface IRefTypeDao
    {
        /// <summary>
        /// Gets the reference types.
        /// </summary>
        /// <returns></returns>
        ObservableCollection<RefTypeEntity> GetRefTypes();

        /// <summary>
        /// Gets the reference type search.
        /// </summary>
        /// <returns></returns>
        ObservableCollection<RefTypeEntity> GetRefTypeSearch();


        RefTypeEntity GetRefType(int refTypeId);

        /// <summary>
        /// Updates the type of the reference.
        /// </summary>
        /// <param name="refTypeEntity">The reference type entity.</param>
        /// <returns></returns>
        string UpdateRefType(RefTypeEntity refTypeEntity);

        string DeleteRefTypeConvert();

        string InsertReftype(RefTypeEntity refTypeEntity);
    }
}

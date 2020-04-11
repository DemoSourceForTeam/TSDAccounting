

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Dictionary;
using System;


namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary
{
    /// <summary>
    /// IEmployeePayItemDao
    /// </summary>
    public interface IEmployeePayItemDao
    {
        /// <summary>
        /// Gets the employee pay items by employee identifier.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        IList<EmployeePayItemEntity> GetEmployeePayItemsByEmployeeId(int employeeId);

        IList<EmployeePayItemEntity> GetEmployeeForEditPayItemsByEmployeeId(int employeeId);

        IList<EmployeePayItemEntity> GetEmployeeForViewtEmployeePayItem(int employeeId, DateTime refDateSalary, decimal exchangeRate);

        /// <summary>
        /// Gets the employee pay item by employee pay item identifier.
        /// </summary>
        /// <param name="employeePayItemId">The employee pay item identifier.</param>
        /// <returns></returns>
        EmployeePayItemEntity GetEmployeePayItemByEmployeePayItemId(int employeePayItemId);

     


        /// <summary>
        /// Inserts the employee pay item.
        /// </summary>
        /// <param name="payItemEntity">The pay item entity.</param>
        /// <returns></returns>
        int InsertEmployeePayItem(EmployeePayItemEntity payItemEntity);

        /// <summary>
        /// Deletes the employee pay item by employee identifier.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        string DeleteEmployeePayItemByEmployeeId(int employeeId);

        string DeleteEditEmployeePayItemByEmployeeId(int employeeId); 
    }
}
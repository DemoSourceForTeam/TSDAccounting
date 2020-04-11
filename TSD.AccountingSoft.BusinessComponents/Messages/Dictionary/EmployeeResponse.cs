

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// EmployeeResponse
    /// </summary>
    public class EmployeeResponse : ResponseBase
    {
        /// <summary>
        /// The employees
        /// </summary>
        public IList<EmployeeEntity> Employees;

        /// <summary>
        /// The employee
        /// </summary>
        public EmployeeEntity Employee;

        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }
    }
}

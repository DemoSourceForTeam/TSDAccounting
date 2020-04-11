

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IEmployeesView
    /// </summary>
    public interface IEmployeesView : IView
    {
        /// <summary>
        /// Sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        IList<EmployeeModel> Employees { set; }
    }
}
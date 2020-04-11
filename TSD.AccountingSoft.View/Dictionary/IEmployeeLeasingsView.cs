

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IEmployeeLeasingsView
    /// </summary>
    public interface IEmployeeLeasingsView
    {
        /// <summary>
        /// Sets the employee leasings.
        /// </summary>
        /// <value>
        /// The employee leasings.
        /// </value>
        IList<EmployeeLeasingModel> EmployeeLeasings { set; }
    }
}

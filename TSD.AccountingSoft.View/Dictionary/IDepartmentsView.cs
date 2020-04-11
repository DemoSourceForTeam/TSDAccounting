

using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using System.Collections.Generic;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IDepartmentsView
    /// </summary>
    public interface IDepartmentsView : IView
    {
        /// <summary>
        /// Sets the departments.
        /// </summary>
        /// <value>
        /// The departments.
        /// </value>
        IList<DepartmentModel> Departments { set; }
    }
}

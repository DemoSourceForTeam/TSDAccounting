

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Salary;


namespace TSD.AccountingSoft.View.Salary
{
    /// <summary>
    /// Interface ISalariesView
    /// </summary>
    public interface ISalariesView : IView  
    {
        /// <summary>
        /// Sets the Salaries.
        /// </summary>
        /// <value>The Salaries.</value>
        IList<SalaryModel> Salaries { set; }  
    }
}

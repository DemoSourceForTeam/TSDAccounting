

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{

    /// <summary>
    /// ICustomersView interface
    /// </summary>
    public interface ICustomersView:IView
    {

        /// <summary>
        /// Sets the customers.
        /// </summary>
        /// <value>
        /// The customers.
        /// </value>
        List<CustomerModel> Customers { set; }
    }
}

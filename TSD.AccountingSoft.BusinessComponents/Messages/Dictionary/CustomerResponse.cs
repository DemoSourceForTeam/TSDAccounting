

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// CustomerResponse class
    /// </summary>
    public class CustomerResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int CustomerId { get; set; }

        /// <summary>
        /// The customer
        /// </summary>
        public CustomerEntity Customer;

        /// <summary>
        /// The customers
        /// </summary>
        public List<CustomerEntity> Customers;
    }
}

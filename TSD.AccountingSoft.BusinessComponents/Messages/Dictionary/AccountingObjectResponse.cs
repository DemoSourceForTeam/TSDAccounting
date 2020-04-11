

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// AccountingObjectResponse class
    /// </summary>
    public class AccountingObjectResponse: ResponseBase
    {

        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int AccountingObjectId { get; set; }

        /// <summary>
        /// The accounting object
        /// </summary>
        public AccountingObjectEntity AccountingObject;

        /// <summary>
        /// The accounting objects
        /// </summary>
        public IList<AccountingObjectEntity> AccountingObjects;
    }
}

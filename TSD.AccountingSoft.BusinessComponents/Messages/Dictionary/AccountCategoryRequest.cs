

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class AccountCategoryRequest.
    /// </summary>
  public  class AccountCategoryRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the account category identifier.
        /// </summary>
        /// <value>The account category identifier.</value>
        public int AccountCategoryId { get; set; }

        /// <summary>
        /// The account category
        /// </summary>
        public AccountCategoryEntity  AccountCategory;
    }
}

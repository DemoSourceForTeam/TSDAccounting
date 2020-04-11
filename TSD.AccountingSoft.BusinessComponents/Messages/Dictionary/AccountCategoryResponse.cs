

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// Class AccountCategoryResponse.
    /// </summary>
    public class AccountCategoryResponse : ResponseBase
    {
        /// <summary>
        /// The account categorys
        /// </summary>
        public IList<AccountCategoryEntity> AccountCategories;

        /// <summary>
        /// The account category
        /// </summary>
        public AccountCategoryEntity AccountCategory;

        /// <summary>
        /// The account category identifier
        /// </summary>
        public int AccountCategoryId;
    }
}

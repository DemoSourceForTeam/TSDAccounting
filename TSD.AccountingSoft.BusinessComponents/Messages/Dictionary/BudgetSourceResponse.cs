

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{

    /// <summary>
    /// Class BudgetSourceResponse.
    /// </summary>
    public class BudgetSourceResponse : ResponseBase
    {
        /// <summary>
        /// The budget sources
        /// </summary>
        public IList<BudgetSourceEntity> BudgetSources;

        /// <summary>
        /// The budget source
        /// </summary>
        public BudgetSourceEntity BudgetSource;

        /// <summary>
        /// The budget source identifier
        /// </summary>
        public int BudgetSourceId;
    }
}

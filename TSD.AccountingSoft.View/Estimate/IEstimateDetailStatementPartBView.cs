

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Report.Estimate;


namespace TSD.AccountingSoft.View.Estimate
{
    /// <summary>
    /// interface IEstimateDetailStatementPartBView
    /// </summary>
    public interface IEstimateDetailStatementPartBView : IView
    {
        /// <summary>
        /// Sets the payment estimates.
        /// </summary>
        /// <value>The payment estimates.</value>
        IList<EstimateDetailStatementPartBModel> EstimateDetailStatementPartB { set; }
    }
}

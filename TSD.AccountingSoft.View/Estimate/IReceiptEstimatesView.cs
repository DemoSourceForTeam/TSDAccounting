

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Estimate;


namespace TSD.AccountingSoft.View.Estimate
{
    /// <summary>
    /// Interface IReceiptEstimatesView
    /// </summary>
    public interface IReceiptEstimatesView : IView
    {
        /// <summary>
        /// Sets the receipt estimates.
        /// </summary>
        /// <value>
        /// The receipt estimates.
        /// </value>
        IList<EstimateModel> ReceiptEstimates { set; }

        IList<EstimateDetailModel> ReceiptEstimateDetails { set; }
    }
}

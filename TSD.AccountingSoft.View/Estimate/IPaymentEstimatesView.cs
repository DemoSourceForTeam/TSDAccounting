

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Estimate;


namespace TSD.AccountingSoft.View.Estimate
{
    /// <summary>
    /// Interface IPaymentEstimatesView
    /// </summary>
    public interface IPaymentEstimatesView : IView
    {
        /// <summary>
        /// Sets the payment estimates.
        /// </summary>
        /// <value>The payment estimates.</value>
        IList<EstimateModel> PaymentEstimates { set; }

        IList<EstimateDetailModel> PaymentEstimateDetails { set; }
    }
}

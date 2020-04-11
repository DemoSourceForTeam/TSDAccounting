

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Estimate;


namespace TSD.AccountingSoft.View.Estimate
{
    /// <summary>
    /// Class IPaymentEstimateDetailsView.
    /// </summary>
    public interface IPaymentEstimateDetailsView
    {
        /// <summary>
        /// Sets the payment estimates.
        /// </summary>
        /// <value>The payment estimates.</value>
        IList<EstimateDetailModel> PaymentEstimateDetails { set; }
    }
}

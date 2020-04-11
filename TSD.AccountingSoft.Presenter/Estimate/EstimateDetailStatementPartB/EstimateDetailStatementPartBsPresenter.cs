

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Report.Estimate;
using TSD.AccountingSoft.View.Estimate;


namespace TSD.AccountingSoft.Presenter.Estimate.EstimateDetailStatementPartB
{
    /// <summary>
    /// class EstimateDetailStatementPartBsPresenter 
    /// </summary>
    public class EstimateDetailStatementPartBsPresenter : Presenter<IEstimateDetailStatementPartBView>
    {
        public EstimateDetailStatementPartBsPresenter(IEstimateDetailStatementPartBView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.EstimateDetailStatementPartB = Model.GetEstimateDetailStatementPartBs();
        }

        /// <summary>
        /// Saves the specified estimate detail statement part b.
        /// </summary>
        /// <param name="estimateDetailStatementPartB">The estimate detail statement part b.</param>
        /// <returns></returns>
        public int Save(IList<EstimateDetailStatementPartBModel> estimateDetailStatementPartB)
        {
            return Model.UpdateEstimateDetailStatementPartB(estimateDetailStatementPartB);
        }
    }
}

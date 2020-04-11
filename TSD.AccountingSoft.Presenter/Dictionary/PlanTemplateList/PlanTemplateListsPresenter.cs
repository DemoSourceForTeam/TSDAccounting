

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.PlanTemplateList
{
    /// <summary>
    /// Class PlanTemplateListsPresenter.
    /// </summary>
    public class PlanTemplateListsPresenter : Presenter<IPlanTemplateListsView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanTemplateListsPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public PlanTemplateListsPresenter(IPlanTemplateListsView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.PlanTemplateLists = Model.GetPlanTemplateLists();
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void DisplayByReceipt()
        {
            View.PlanTemplateLists = Model.GetPlanTemplateListsByReceipt();
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void DisplayByPayment()
        {
            View.PlanTemplateLists = Model.GetPlanTemplateListsByPayment();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void DisplayActive()
        {
            View.PlanTemplateLists = Model.GetPlanTemplateLists();
        }
    }
}

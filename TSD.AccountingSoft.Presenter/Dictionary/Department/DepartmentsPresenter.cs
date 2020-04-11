

using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.Department
{
    /// <summary>
    /// DepartmentsPresenter
    /// </summary>
    public class DepartmentsPresenter : Presenter<IDepartmentsView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentsPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public DepartmentsPresenter(IDepartmentsView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            View.Departments = Model.GetDepartments();
        }

        /// <summary>
        /// Displays the active.
        /// </summary>
        public void DisplayActive()
        {
            View.Departments = Model.GetDepartmentsActive();
        }
    }
}

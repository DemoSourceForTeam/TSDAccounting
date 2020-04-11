

using TSD.AccountingSoft.Model;

namespace TSD.AccountingSoft.Report.ReportClass
{
    /// <summary>
    /// DepositReport
    /// </summary>
    public class DepositReport : BaseReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositReport"/> class.
        /// </summary>
        public DepositReport()
        {
            Model = new TSD.AccountingSoft.Model.Model();
        }
    }
}



using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;


namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IAudittingLogsView
    /// </summary>
    public interface IAudittingLogsView : IView
    {
        /// <summary>
        /// Sets the auditting logs.
        /// </summary>
        /// <value>
        /// The auditting logs.
        /// </value>
        IList<AudittingLogModel> AudittingLogs { set; }
    }
}

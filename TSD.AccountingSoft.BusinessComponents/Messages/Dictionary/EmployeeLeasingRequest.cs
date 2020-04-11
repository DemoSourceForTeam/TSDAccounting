

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// EmployeeLeasingRequest
    /// </summary>
    public class EmployeeLeasingRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the employeeLeasing identifier.
        /// </summary>
        /// <value>
        /// The employeeLeasing identifier.
        /// </value>
        public int EmployeeLeasingId;

        /// <summary>
        /// The employeeLeasing
        /// </summary>
        public EmployeeLeasingEntity EmployeeLeasing;

        /// <summary>
        /// The is leasing
        /// </summary>
        public bool IsLeasing;
    }
}

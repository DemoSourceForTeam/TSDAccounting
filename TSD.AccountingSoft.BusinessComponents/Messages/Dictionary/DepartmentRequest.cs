

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// DepartmentRequest
    /// </summary>
    public class DepartmentRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int DepartmentId { get; set; }

        /// <summary>
        /// The department
        /// </summary>
        public DepartmentEntity Department;
    }
}

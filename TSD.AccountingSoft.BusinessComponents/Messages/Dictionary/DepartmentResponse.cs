

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Dictionary;


namespace TSD.AccountingSoft.BusinessComponents.Messages.Dictionary
{
    /// <summary>
    /// DepartmentResponse
    /// </summary>
    public class DepartmentResponse : ResponseBase
    {
        /// <summary>
        /// The departments
        /// </summary>
        public IList<DepartmentEntity> Departments;

        /// <summary>
        /// The department
        /// </summary>
        public DepartmentEntity Department;

        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int DepartmentId { get; set; }
    }
}
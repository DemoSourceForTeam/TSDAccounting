

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// interface IProjectView
    /// </summary>
    public interface IProjectView
    {
        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>
        /// The project identifier.
        /// </value>
        int ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the project code.
        /// </summary>
        /// <value>
        /// The project code.
        /// </value>
        string ProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>
        /// The name of the project.
        /// </value>
        string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the name of the foreign.
        /// </summary>
        /// <value>
        /// The name of the foreign.
        /// </value>
        string ForeignName { get; set; }

        /// <summary>
        /// Gets or sets the parent identifier.
        /// </summary>
        /// <value>
        /// The parent identifier.
        /// </value>
        int? ParentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is parent].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is parent]; otherwise, <c>false</c>.
        /// </value>
        bool IsParent { get; set; }

        /// <summary>
        /// Gets or sets the grade.
        /// </summary>
        /// <value>
        /// The grade.
        /// </value>
        int Grade { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [is active].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is active]; otherwise, <c>false</c>.
        /// </value>
        bool IsActive { get; set; }
    }
}

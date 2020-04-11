

namespace TSD.AccountingSoft.BusinessEntities.BusinessRules
{
    /// <summary>
    /// Email validation rule.
    /// </summary>
    public class ValidateEmail : ValidateRegex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmail"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public ValidateEmail(string propertyName) :
            base(propertyName, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
        {
            ErrorMessage = propertyName + " is not a valid email address";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmail"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="errorMessage">The error message.</param>
        public ValidateEmail(string propertyName, string errorMessage) :
            this(propertyName)
        {
            ErrorMessage = errorMessage;
        }
    }
}

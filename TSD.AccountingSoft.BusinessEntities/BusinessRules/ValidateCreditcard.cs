

namespace TSD.AccountingSoft.BusinessEntities.BusinessRules
{
    /// <summary>
    /// class ValidateCreditcard
    /// </summary>
    public class ValidateCreditcard : ValidateRegex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateCreditcard"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public ValidateCreditcard(string propertyName) :
            base(propertyName, @"^((\d{4}[- ]?){3}\d{4})$")
        {
            ErrorMessage = propertyName + " is not a valid credit card number";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateCreditcard"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="errorMessage">The error message.</param>
        public ValidateCreditcard(string propertyName, string errorMessage) :
            this(propertyName)
        {
            ErrorMessage = errorMessage;
        }
    }
}



namespace TSD.AccountingSoft.Model.BusinessObjects.Dictionary
{
    /// <summary>
    /// AutoNumberModel
    /// </summary>
    public class AutoNumberModel
    {
        /// <summary>
        /// Gets or sets the reference type identifier.
        /// </summary>
        /// <value>
        /// The reference type identifier.
        /// </value>
        public int RefTypeId { get; set; }

        /// <summary>
        /// Gets or sets the prefix.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets the suffix.
        /// </summary>
        /// <value>
        /// The suffix.
        /// </value>
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the value local curency.
        /// </summary>
        /// <value>
        /// The value local curency.
        /// </value>
        public int ValueLocalCurency { get; set; }

        /// <summary>
        /// Gets or sets the length of value.
        /// </summary>
        /// <value>
        /// The length of value.
        /// </value>
        public int LengthOfValue { get; set; }
    }
}

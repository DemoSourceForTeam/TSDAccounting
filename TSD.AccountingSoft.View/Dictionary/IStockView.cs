

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IStockView
    /// </summary>
    public interface IStockView : IView
    {
        /// <summary>
        /// Gets or sets the cus identifier.
        /// </summary>
        /// <value>
        /// The cus identifier.
        /// </value>
        int StockId { get; set; }

        /// <summary>
        /// Gets or sets the cus identifier.
        /// </summary>
        /// <value>
        /// The cus identifier.
        /// </value>
        string StockCode { get; set; }

        /// <summary>
        /// Gets or sets the cus identifier.
        /// </summary>
        /// <value>
        /// The cus identifier.
        /// </value>
        string StockName { get; set; }

        /// <summary>
        /// Gets or sets the cus identifier.
        /// </summary>
        /// <value>
        /// The cus identifier.
        /// </value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the cus identifier.
        /// </summary>
        /// <value>
        /// The cus identifier.
        /// </value>
        bool IsActive { get; set; }
    }
}

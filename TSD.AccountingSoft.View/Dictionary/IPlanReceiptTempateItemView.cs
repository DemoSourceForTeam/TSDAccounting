

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IPlanReceiptTempateItemView
    /// </summary>
   public interface IPlanReceiptTempateItemView : IView
    {
        /// <summary>
        /// Gets or sets the plan receipt tempate item identifier.
        /// </summary>
        /// <value>
        /// The plan receipt tempate item identifier.
        /// </value>
       int PlanReceiptTempateItemId { get; set; }

       /// <summary>
       /// Gets or sets the name of the item.
       /// </summary>
       /// <value>
       /// The name of the item.
       /// </value>
       string ItemName { get; set; }

       /// <summary>
       /// Gets or sets the number order.
       /// </summary>
       /// <value>
       /// The number order.
       /// </value>
       string NumberOrder { get; set; }

       /// <summary>
       /// Gets or sets the budget item code list.
       /// </summary>
       /// <value>
       /// The budget item code list.
       /// </value>
       string BudgetItemCodeList { get; set; }

       /// <summary>
       /// Gets or sets the font style.
       /// </summary>
       /// <value>
       /// The font style.
       /// </value>
       string FontStyle { get; set; }
    }
}

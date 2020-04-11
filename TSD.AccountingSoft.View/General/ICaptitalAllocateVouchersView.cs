

using System;
using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.General;


namespace TSD.AccountingSoft.View.General
{
    public interface ICaptitalAllocateVouchersView
    {
        /// <summary>
        /// Sets the get captital allocate vouchers for update or insert.
        /// </summary>
        /// <value>
        /// The get captital allocate vouchers for update or insert.
        /// </value>
        IList<CaptitalAllocateVoucherModel> GetCaptitalAllocateVouchersForUpdateOrInsert { set; }


        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
          string CurrencyCode { get; set; }

          /// <summary>
          /// Gets or sets from date.
          /// </summary>
          /// <value>
          /// From date.
          /// </value>
         DateTime FromDate { get; set; }

         /// <summary>
         /// Gets or sets to date.
         /// </summary>
         /// <value>
         /// To date.
         /// </value>
         DateTime ToDate { get; set; }

         int ActivityId { get; set; }
    }
}

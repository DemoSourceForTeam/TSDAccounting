﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.AccountingSoft.View.OpeningSupplyEntry
{
    public interface IOpeningSupplyEntryView : IView
    {
        long RefId { get; set; }
        int RefType { get; set; }
        DateTime PostedDate { get; set; }
        DateTime RefDate { get; set; }
        string CurrencyCode { get; set; }
        decimal ExchangeRate { get; set; }
        string AccountNumber { get; set; }
        int InventoryItemId { get; set; }
        int DepartmentId { get; set; }
        decimal Quantity { get; set; }
        decimal UnitPriceOc { get; set; }
        decimal UnitPriceExchange { get; set; }
        decimal AmountOc { get; set; }
        decimal AmountExchange { get; set; }
        int SortOrder { get; set; }
    }
}

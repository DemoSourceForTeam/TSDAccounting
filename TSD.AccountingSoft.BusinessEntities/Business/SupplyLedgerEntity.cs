﻿

using System;

namespace TSD.AccountingSoft.BusinessEntities.Business
{
    public class SupplyLedgerEntity
    {
        public long SupplyLedgerId { get; set; }
        public long RefId { get; set; }
        public long RefDetailId { get; set; }
        public int RefType { get; set; }
        public string RefNo { get; set; }
        public DateTime RefDate { get; set; }
        public DateTime PostedDate { get; set; }
        public string Description { get; set; }
        public string JournalMemo { get; set; }
        public int InventoryItemId { get; set; }
        public int DepartmentId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPriceOc { get; set; }
        public decimal UnitPriceExchange { get; set; }
        public decimal AmountOc { get; set; }
        public decimal AmountExchange { get; set; }
    }
}

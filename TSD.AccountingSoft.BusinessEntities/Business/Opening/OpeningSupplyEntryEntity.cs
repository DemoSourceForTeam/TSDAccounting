

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.AccountingSoft.BusinessEntities.Business.Opening
{
    public class OpeningSupplyEntryEntity : BusinessEntities
    {
        public long RefId { get; set; }
        public int RefType { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime RefDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string AccountNumber { get; set; }
        public int InventoryItemId { get; set; }
        public int DepartmentId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPriceOc { get; set; }
        public decimal UnitPriceExchange { get; set; }
        public decimal AmountOc { get; set; }
        public decimal AmountExchange { get; set; }
        public int SortOrder { get; set; }
    }
}

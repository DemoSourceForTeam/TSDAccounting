

namespace TSD.AccountingSoft.Model.BusinessObjects.Dictionary
{
    /// <summary>
    /// AutoBusinessModel
    /// </summary>
    public class AutoBusinessModel
    {
        public int AutoBusinessId { get; set; }

        public string AutoBusinessCode { get; set; }

        public string AutoBusinessName { get; set; }

        public int RefTypeId { get; set; }

        public int? VoucherTypeId { get; set; }

        public string DebitAccountNumber { get; set; }

        public string CreditAccountNumber { get; set; }

        public string BudgetSourceCode { get; set; }

        public string BudgetItemCode { get; set; }

        public string Description { get; set; }

        public string CurrencyCode { get; set; }

        public bool IsActive { get; set; }
    }
}

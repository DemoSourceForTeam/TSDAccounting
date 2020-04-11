﻿

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// IAutoBusinessView
    /// </summary>
    public interface IAutoBusinessView : IView
    {
        int AutoBusinessId { get; set; }

        string AutoBusinessCode { get; set; }

        string AutoBusinessName { get; set; }

        int RefTypeId { get; set; }

        int? VoucherTypeId { get; set; }

        string DebitAccountNumber { get; set; }

        string CreditAccountNumber { get; set; }

        string BudgetSourceCode { get; set; }

        string BudgetItemCode { get; set; }

        string Description { get; set; }

        string CurrencyCode { get; set; }

        bool IsActive { get; set; }
    }
}

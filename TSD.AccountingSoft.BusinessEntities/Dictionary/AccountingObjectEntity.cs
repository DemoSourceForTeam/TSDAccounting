

using System;
using TSD.AccountingSoft.BusinessEntities.BusinessRules;


namespace TSD.AccountingSoft.BusinessEntities.Dictionary
{
    public class AccountingObjectEntity : BusinessEntities
    {
        public AccountingObjectEntity()
        {
            AddRule(new ValidateId("AccountingObjectId"));
            AddRule(new ValidateLength("AccountingObjectCode", 1, 50));
            AddRule(new ValidateLength("FullName", 1, 255));
        }

        public int AccountingObjectId { get; set; }
        public string AccountingObjectCode { get; set; }
        public int? AccountingObjectCategoryId { get; set; }
        public int? Type { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public string BankAcount { get; set; }
        public string BankName { get; set; }
        public int? BankId { get; set; }
        public string ContactName { get; set; }
        public string ContactAddress { get; set; }
        public string ContactIdNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueAddress { get; set; }
        public bool IsActive { get; set; }
    }
}

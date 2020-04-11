

using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Salary
{
    public class SalaryVoucherRequest : RequestBase
    {

        public int ReftypeId { get; set; }
        public string RefNo { get; set; }
        public string PostedDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsRetail { get; set; }
    }
}

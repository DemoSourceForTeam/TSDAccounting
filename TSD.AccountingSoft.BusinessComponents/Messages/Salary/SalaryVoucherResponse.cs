

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.BusinessEntities.Salary;

namespace TSD.AccountingSoft.BusinessComponents.Messages.Salary
{
    public class SalaryVoucherResponse : ResponseBase
    {
        public int ReftypeId { get; set; }
        public string RefNo { get; set; }
        public string PostedDate { get; set; }
        public List<SalaryVoucherEntity> SalaryVouchers { get; set; }
        public SalaryVoucherEntity SalaryVoucher { get; set; }

    }
}

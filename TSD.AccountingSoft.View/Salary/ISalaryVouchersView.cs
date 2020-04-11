

using System.Collections.Generic;
using TSD.AccountingSoft.Model.BusinessObjects.Salary;

namespace TSD.AccountingSoft.View.Salary
{
        public interface ISalaryVouchersView : IView
        {
            IList<SalaryVoucherModel> SalaryVouchers { set; }
        }
    }


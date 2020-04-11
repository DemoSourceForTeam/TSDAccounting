

using System.Collections.Generic;
using TSD.AccountingSoft.BusinessEntities.Salary;

namespace TSD.AccountingSoft.DataAccess.IEntitiesDao.Salary
{
    public interface ISalaryVoucherDao
    {
        List<SalaryVoucherEntity> GetSalaryVoucherMonthDate(string monthDate);

        List<SalaryVoucherEntity> GetSalaryVoucherMonthDateIsPostedDate(string monthDate);

        List<SalaryVoucherEntity> GetSalaryVoucherIsRetail(string monthDate,bool isRetail,int refTypeId);

        string Update_EmployeePayroll_Voucher(string refNo, long? cashId, long? depositID);

        long GetEmployeePayroll_VoucherID(string refNo, int RefTypeId);

        string CanclCalc(string monthDate, string refNo);
        
    }
}

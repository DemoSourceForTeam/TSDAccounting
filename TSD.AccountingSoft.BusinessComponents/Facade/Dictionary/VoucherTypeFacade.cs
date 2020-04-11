using System.Linq;
using TSD.AccountingSoft.BusinessComponents.Messages.Dictionary;
using TSD.AccountingSoft.DataAccess.IEntitiesDao.Dictionary;

namespace TSD.AccountingSoft.BusinessComponents.Facade.Dictionary
{
    public class VoucherTypeFacade
    {
        private static readonly IVoucherTypeDao VoucherTypeDao = DataAccess.DataAccess.VoucherTypeDao;

        public VoucherTypeResponse GetVoucherTypes(VoucherTypeRequest request)
        {
            var response = new VoucherTypeResponse();

            if (request.LoadOptions.Contains("VoucherTypes"))
            {
                response.VoucherTypes = request.LoadOptions.Contains("IsActive") ? VoucherTypeDao.GetVoucherTypesByIsActive(true) : VoucherTypeDao.GetVoucherTypes();
            }
            if(request.LoadOptions.Contains("VoucherType"))
            {
                if (request.LoadOptions.Contains("ByCode"))
                    response.VoucherType = VoucherTypeDao.GetVoucherTypeByCode(request.Code);
            }

            return response;
        }
    }
}

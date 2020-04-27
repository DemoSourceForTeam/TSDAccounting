using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.AccountingSoft.Models.BusinessObject.Dictionary;

namespace TSD.AccountingSoft.Models
{
    public interface IProvider
    {
        #region RefType
        #region Master
        ObservableCollection<RefTypeModel> GetRefTypeModels();
        RefTypeModel GetRefTypeModel(int refType);

        string AddRefType(RefTypeModel refTypeModel);
        string UpdateRefType(RefTypeModel refTypeModel);
        string DeleteRefType(RefTypeModel refTypeModel);

        #endregion
        ObservableCollection<RefTypeModel> GetRefTypeDetailModels();
        RefTypeModel GetRefTypeDeModel();

        string AddRefTypeDetail(RefTypeDetailModel refTypeDetailModel);
      
        string DeleteRefTypeDetail(RefTypeModel refTypeModel);

        #endregion


    }
}

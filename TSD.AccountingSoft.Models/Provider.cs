using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.AccountingSoft.Models.BusinessObject.Dictionary;

namespace TSD.AccountingSoft.Models
{
    public class Provider : IProvider
    {
        public string AddRefType(RefTypeModel refTypeModel)
        {
            throw new NotImplementedException();
        }

        public string AddRefTypeDetail(RefTypeDetailModel refTypeDetailModel)
        {
            throw new NotImplementedException();
        }

        public string DeleteRefType(RefTypeModel refTypeModel)
        {
            throw new NotImplementedException();
        }

        public string DeleteRefTypeDetail(RefTypeModel refTypeModel)
        {
            throw new NotImplementedException();
        }

        public RefTypeModel GetRefTypeDeModel()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<RefTypeModel> GetRefTypeDetailModels()
        {
            throw new NotImplementedException();
        }

        public RefTypeModel GetRefTypeModel(int refType)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<RefTypeModel> GetRefTypeModels()
        {
            var abs = new ObservableCollection<RefTypeModel>();
            var ab = new RefTypeModel();
            ab.RefTypeID = 1;
            ab.RefTypeCation = "testc";
            abs.Add(ab);
            return abs;
        }

        public string UpdateRefType(RefTypeModel refTypeModel)
        {
            throw new NotImplementedException();
        }
    }
}

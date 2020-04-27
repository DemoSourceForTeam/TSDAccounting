using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.AccountingSoft.BusinessComponents.Messages.MessageBase;
using TSD.AccountingSoft.Models.BusinessObject.Dictionary;
using TSD.AccountingSoft.Models.BusinessObject.Mapper;
using TSD.AccountingSoft.BusinessComponents.Messages.Dictionary;
using TSD.AccountingSoft.BusinessComponents.Facade.Dictionary;


namespace TSD.AccountingSoft.Models
{
    public class Provider : IProvider
    {
        private static readonly RefTypeFacade RefTypeClient = new RefTypeFacade();


        private static T PrepareRequest<T>(T request) where T : RequestBase
        {
            return request;
        }

        #region RefType
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
            var request = PrepareRequest(new RefTypeRequest());
            request.LoadOptions = new[] { "RefTypes" };

            var response = RefTypeClient.GetRefTypes(request);
            if (response.Acknowledge != AcknowledgeType.Success) throw new ApplicationException(response.Message);

            return DictionaryMapper.FromDataTransferObjects(response.RefTypes);
        }

        public string UpdateRefType(RefTypeModel refTypeModel)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
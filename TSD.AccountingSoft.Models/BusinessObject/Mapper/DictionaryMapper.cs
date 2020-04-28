using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.AccountingSoft.Models.BusinessObject.Dictionary;
using TSD.AccountingSoft.BusinessEntities.Dictionary;
using System.Collections.ObjectModel;

namespace TSD.AccountingSoft.Models.BusinessObject.Mapper
{
    public class DictionaryMapper
    {
        static DictionaryMapper()
            {
            AutoMapper.Mapper.CreateMap<RefTypeModel, RefTypeEntity>();
            AutoMapper.Mapper.CreateMap<RefTypeEntity, RefTypeModel>();
            AutoMapper.Mapper.CreateMap<RefTypeDetailModel, RefTypeDetailEntity>();
            AutoMapper.Mapper.CreateMap<RefTypeDetailEntity, RefTypeDetailModel>();
            }

        #region RefType
         
        internal static RefTypeModel FromDataTransferObject(RefTypeEntity entity)
        {
            return entity == null ? null : AutoMapper.Mapper.Map<RefTypeEntity, RefTypeModel>(entity);
        }

        internal static RefTypeEntity ToDataTransferObject(RefTypeModel model)
        {
            return model == null ? null : AutoMapper.Mapper.Map<RefTypeModel, RefTypeEntity>(model);
        }

        internal static ObservableCollection<RefTypeModel> FromDataTransferObjects(ObservableCollection<RefTypeEntity> entities)
        {
            return entities == null ? null : AutoMapper.Mapper.Map<ObservableCollection<RefTypeEntity>, ObservableCollection<RefTypeModel>>(entities);
        }

        internal static ObservableCollection<RefTypeEntity> ToDataTransferObjects(ObservableCollection<RefTypeModel> models)
        {
            return models == null ? null : AutoMapper.Mapper.Map<ObservableCollection<RefTypeModel>, ObservableCollection<RefTypeEntity>>(models);
        }

        internal static RefTypeDetailModel FromDataTransferObject(RefTypeDetailEntity entity)
        {
            return entity == null ? null : AutoMapper.Mapper.Map<RefTypeDetailEntity, RefTypeDetailModel>(entity);
        }

        internal static RefTypeDetailEntity ToDataTransferObject(RefTypeDetailModel model)
        {
            return model == null ? null : AutoMapper.Mapper.Map<RefTypeDetailModel, RefTypeDetailEntity>(model);
        }

        internal static ObservableCollection<RefTypeDetailModel> FromDataTransferObjects(ObservableCollection<RefTypeDetailEntity> entities)
        {
            return entities == null ? null : AutoMapper.Mapper.Map<ObservableCollection<RefTypeDetailEntity>, ObservableCollection<RefTypeDetailModel>>(entities);
        }

        internal static ObservableCollection<RefTypeDetailEntity> ToDataTransferObjects(ObservableCollection<RefTypeDetailModel> models)
        {
            return models == null ? null : AutoMapper.Mapper.Map<ObservableCollection<RefTypeDetailModel>, ObservableCollection<RefTypeDetailEntity>>(models);
        }

        #endregion
    }
}

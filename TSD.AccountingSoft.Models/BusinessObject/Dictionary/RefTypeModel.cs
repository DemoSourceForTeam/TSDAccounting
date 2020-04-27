

using System.Collections.ObjectModel;

namespace TSD.AccountingSoft.Models.BusinessObject.Dictionary
{
    public class RefTypeModel
    {
        public long RefTypeID { get; set; }
        public string RefTypeCode { get; set; }
        public string RefTypeName { get; set; }
        public string RefTypeCation { get; set; }
        public string FrmDetail { get; set; }
        public string NameSpace { get; set; }
        public int SystemType { get; set; }
        public bool IsEnable { get; set; }
        public ObservableCollection<RefTypeDetailModel> RefTypeDetailModels { get; set; }
    }
}

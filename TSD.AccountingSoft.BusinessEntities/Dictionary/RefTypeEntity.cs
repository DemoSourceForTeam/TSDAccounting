


using System.Collections.ObjectModel;

namespace TSD.AccountingSoft.BusinessEntities.Dictionary
{
    /// <summary>
    /// RefTypeEntity
    /// </summary>
    public class RefTypeEntity : BusinessEntities
    {
        /// <summary>
        public long RefTypeID { get; set; }
        public string RefTypeCode { get; set; }
        public string RefTypeName { get; set; }
        public string RefTypeCation { get; set; }
        public string FrmDetail { get; set; }
        public string NameSpace { get; set; }
        public int SystemType { get; set; }
        public bool IsEnable { get; set; }
        public ObservableCollection<RefTypeDetailEntity> RefTypeDetailEntity { get; set; }
    }
}

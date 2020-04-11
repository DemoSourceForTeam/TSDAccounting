

namespace TSD.AccountingSoft.Model.BusinessObjects.Report
{
    public class ReportGroupModel
    {
        public int ReportGroupID { get; set; }
        public string ReportGroupName { get; set; }
        public string Description { get; set; }
        public bool IsVoucher { get; set; }
        public bool IsActive { get; set; }
    }
}

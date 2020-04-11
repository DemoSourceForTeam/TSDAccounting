

namespace TSD.AccountingSoft.BusinessEntities.Report.Finacial
{
    public class B09BNGEntity
    {
        public string ItemId { get; set; }
        public string ParentId { get; set; }
        public int Grade { get; set; }
        public string ItemName { get; set; }
        public decimal Amount { get; set; }
        public decimal AccumulatedAmount { get; set; }
        public string FontStyle { get; set; }
        public int QuarterB09 { get; set; }
    }
}

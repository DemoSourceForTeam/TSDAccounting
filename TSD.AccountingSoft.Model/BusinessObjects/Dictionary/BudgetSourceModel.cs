

namespace TSD.AccountingSoft.Model.BusinessObjects.Dictionary
{
    /// <summary>
    /// Class BudgetSourceModel.
    /// </summary>
    public class BudgetSourceModel
    {
        public int BudgetSourceId { get; set; }

        public string BudgetSourceCode { get; set; }

        public string BudgetSourceName { get; set; }

        public string ForeignName { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set; }

        public int Grade { get; set; }

        public bool IsParent { get; set; }

        public int Type { get; set; }

        public bool IsSystem { get; set; }

        public bool IsActive { get; set; }

        public int Allocation { get; set; }

        public string BudgetItemCode { get; set; }

        public bool IsFund { get; set; }

        public bool IsExpense { get; set; }

        public string  AccountCode { get; set; }

        public short? AutonomyBudgetType { get; set; }

        public int BudgetCode { get; set; }
    }
}

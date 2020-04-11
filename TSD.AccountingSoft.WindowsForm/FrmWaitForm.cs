

using DevExpress.XtraWaitForm;

namespace TSD.AccountingSoft.WindowsForm
{
    public partial class FrmWaitForm : WaitForm
    {
        public FrmWaitForm()
        {
            InitializeComponent();
            progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            progressPanel1.Description = description;
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        private void FrmWaitForm_Load(object sender, System.EventArgs e)
        {
            SetCaption("Chương trình đang sao lưu dữ liệu");
            SetDescription("Vui lòng đợi ...");
        }
    }
}
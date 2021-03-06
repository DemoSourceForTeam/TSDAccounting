﻿namespace TSD.AccountingSoft.Report.ParameterReportForm
{
    partial class FrmA02LDTLLE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioVoucher = new System.Windows.Forms.RadioButton();
            this.radioEmloyee = new System.Windows.Forms.RadioButton();
            this.dateTimeRangeV1 = new DateTimeRangeBlockDev.DateTimeRangeV();
            this.grdEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdVoucher = new DevExpress.XtraGrid.GridControl();
            this.grdViewVoucher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkMoveTotalInNewPage = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupboxMain)).BeginInit();
            this.groupboxMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMoveTotalInNewPage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxMain
            // 
            this.groupboxMain.Controls.Add(this.chkMoveTotalInNewPage);
            this.groupboxMain.Controls.Add(this.grdVoucher);
            this.groupboxMain.Controls.Add(this.grdEmployee);
            this.groupboxMain.Controls.Add(this.groupBox1);
            this.groupboxMain.Controls.Add(this.dateTimeRangeV1);
            this.groupboxMain.Size = new System.Drawing.Size(471, 314);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(320, 339);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 339);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(7, 339);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioVoucher);
            this.groupBox1.Controls.Add(this.radioEmloyee);
            this.groupBox1.Location = new System.Drawing.Point(310, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 54);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // radioVoucher
            // 
            this.radioVoucher.AutoSize = true;
            this.radioVoucher.Checked = true;
            this.radioVoucher.Location = new System.Drawing.Point(6, 11);
            this.radioVoucher.Name = "radioVoucher";
            this.radioVoucher.Size = new System.Drawing.Size(122, 17);
            this.radioVoucher.TabIndex = 16;
            this.radioVoucher.TabStop = true;
            this.radioVoucher.Text = "Chọn theo chứng từ";
            this.radioVoucher.UseVisualStyleBackColor = true;
            // 
            // radioEmloyee
            // 
            this.radioEmloyee.AutoSize = true;
            this.radioEmloyee.Location = new System.Drawing.Point(6, 35);
            this.radioEmloyee.Name = "radioEmloyee";
            this.radioEmloyee.Size = new System.Drawing.Size(125, 17);
            this.radioEmloyee.TabIndex = 15;
            this.radioEmloyee.Text = "Chọn theo nhân viên";
            this.radioEmloyee.UseVisualStyleBackColor = true;
            // 
            // dateTimeRangeV1
            // 
            this.dateTimeRangeV1.DateRangePeriodMode = DateTimeRangeBlockDev.Helper.DateRangeMode.All;
            this.dateTimeRangeV1.FromDate = new System.DateTime(((long)(0)));
            this.dateTimeRangeV1.FromDateLabelText = "Từ ngày";
            this.dateTimeRangeV1.InitSelectedIndex = 0;
            this.dateTimeRangeV1.Location = new System.Drawing.Point(14, 5);
            this.dateTimeRangeV1.MinimumSize = new System.Drawing.Size(290, 70);
            this.dateTimeRangeV1.Name = "dateTimeRangeV1";
            this.dateTimeRangeV1.PeriodLabelText = "Kỳ báo cáo";
            this.dateTimeRangeV1.Size = new System.Drawing.Size(290, 72);
            this.dateTimeRangeV1.TabIndex = 17;
            this.dateTimeRangeV1.ToDate = new System.DateTime(((long)(0)));
            this.dateTimeRangeV1.ToDateLabelText = "Đến ngày";
            // 
            // grdEmployee
            // 
            this.grdEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdEmployee.Location = new System.Drawing.Point(8, 83);
            this.grdEmployee.MainView = this.gridViewEmployee;
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.Size = new System.Drawing.Size(444, 181);
            this.grdEmployee.TabIndex = 19;
            this.grdEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployee});
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewEmployee.GridControl = this.grdEmployee;
            this.gridViewEmployee.Name = "gridViewEmployee";
            this.gridViewEmployee.OptionsBehavior.Editable = false;
            this.gridViewEmployee.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewEmployee.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridViewEmployee.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewEmployee.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewEmployee.OptionsSelection.MultiSelect = true;
            this.gridViewEmployee.OptionsView.ShowGroupPanel = false;
            this.gridViewEmployee.OptionsView.ShowIndicator = false;
            this.gridViewEmployee.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewEmployee.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewEmployee_RowClick);
            // 
            // grdVoucher
            // 
            this.grdVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdVoucher.Location = new System.Drawing.Point(8, 83);
            this.grdVoucher.MainView = this.grdViewVoucher;
            this.grdVoucher.Name = "grdVoucher";
            this.grdVoucher.Size = new System.Drawing.Size(444, 196);
            this.grdVoucher.TabIndex = 20;
            this.grdVoucher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewVoucher});
            // 
            // grdViewVoucher
            // 
            this.grdViewVoucher.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grdViewVoucher.GridControl = this.grdVoucher;
            this.grdViewVoucher.Name = "grdViewVoucher";
            this.grdViewVoucher.OptionsBehavior.Editable = false;
            this.grdViewVoucher.OptionsNavigation.AutoFocusNewRow = true;
            this.grdViewVoucher.OptionsNavigation.AutoMoveRowFocus = false;
            this.grdViewVoucher.OptionsNavigation.EnterMoveNextColumn = true;
            this.grdViewVoucher.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdViewVoucher.OptionsSelection.MultiSelect = true;
            this.grdViewVoucher.OptionsView.ShowGroupPanel = false;
            this.grdViewVoucher.OptionsView.ShowIndicator = false;
            this.grdViewVoucher.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.grdViewVoucher.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdViewVoucher_RowClick);
            // 
            // chkMoveTotalInNewPage
            // 
            this.chkMoveTotalInNewPage.Location = new System.Drawing.Point(10, 289);
            this.chkMoveTotalInNewPage.Name = "chkMoveTotalInNewPage";
            this.chkMoveTotalInNewPage.Properties.Caption = "Chuyển dòng tổng cộng qua trang mới";
            this.chkMoveTotalInNewPage.Size = new System.Drawing.Size(208, 19);
            this.chkMoveTotalInNewPage.TabIndex = 21;
            this.chkMoveTotalInNewPage.ToolTip = "Chỉ dùng trong trường hợp khi in báo cáo mà phần chữ ký ở trang mới và trước phần" +
    " chữ ký không có số liệu.";
            // 
            // FrmA02LDTLLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 373);
            this.Name = "FrmA02LDTLLE";
            this.Text = "Sinh hoạt phí lẻ";
            this.Load += new System.EventHandler(this.FrmA02LDTLLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupboxMain)).EndInit();
            this.groupboxMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMoveTotalInNewPage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioVoucher;
        private System.Windows.Forms.RadioButton radioEmloyee;
        private DateTimeRangeBlockDev.DateTimeRangeV dateTimeRangeV1;
        private DevExpress.XtraGrid.GridControl grdEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployee;
        private DevExpress.XtraGrid.GridControl grdVoucher;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewVoucher;
        private DevExpress.XtraEditors.CheckEdit chkMoveTotalInNewPage;
    }
}
namespace PivotSample
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup3 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup4 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.nwindDataSet = new PivotSample.nwindDataSet();
            this.customerReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerReportsTableAdapter = new PivotSample.nwindDataSetTableAdapters.CustomerReportsTableAdapter();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.customFieldFilterControl1 = new PivotSample.CustomFieldFilterControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            pivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            pivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = true;
            pivotGridStyleFormatCondition1.ApplyToCell = false;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            pivotGridStyleFormatCondition1.FieldName = "";
            pivotGridStyleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pivotGridControl1.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1});
            pivotGridGroup1.Caption = "Category Name";
            pivotGridGroup1.Hierarchy = "[Categories].[Category Name]";
            pivotGridGroup1.ShowNewValues = true;
            pivotGridGroup2.Caption = "City";
            pivotGridGroup2.Hierarchy = "[Customers].[City]";
            pivotGridGroup2.ShowNewValues = true;
            pivotGridGroup3.Caption = "Country";
            pivotGridGroup3.Hierarchy = "[Customers].[Country]";
            pivotGridGroup3.ShowNewValues = true;
            pivotGridGroup4.Caption = "Products";
            pivotGridGroup4.Hierarchy = "[Products].[Products]";
            pivotGridGroup4.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2,
            pivotGridGroup3,
            pivotGridGroup4});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OLAPConnectionString = "";
            this.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea;
            this.pivotGridControl1.OptionsDataField.AreaIndex = 0;
            this.pivotGridControl1.OptionsView.RowTreeWidth = 238;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowTotalsForSingleValues = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(593, 500);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pivotGridControl1_MouseDown);
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.FieldName = "Date";
            this.pivotGridField4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.pivotGridField4.Name = "pivotGridField4";
            this.pivotGridField4.UnboundFieldName = "pivotGridField3";
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerReportsBindingSource
            // 
            this.customerReportsBindingSource.DataMember = "CustomerReports";
            this.customerReportsBindingSource.DataSource = this.nwindDataSet;
            // 
            // customerReportsTableAdapter
            // 
            this.customerReportsTableAdapter.ClearBeforeFill = true;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.customFieldFilterControl1);
            this.popupControlContainer1.Controls.Add(this.panelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(139, 189);
            this.popupControlContainer1.Manager = this.barManager1;
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(404, 287);
            this.popupControlContainer1.TabIndex = 3;
            this.popupControlContainer1.Visible = false;
            // 
            // customFieldFilterControl1
            // 
            this.customFieldFilterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customFieldFilterControl1.Field = null;
            this.customFieldFilterControl1.Location = new System.Drawing.Point(0, 0);
            this.customFieldFilterControl1.Name = "customFieldFilterControl1";
            this.customFieldFilterControl1.Size = new System.Drawing.Size(404, 261);
            this.customFieldFilterControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 261);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(404, 26);
            this.panelControl1.TabIndex = 2;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton3.Location = new System.Drawing.Point(252, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 22);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "Ok";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton4.Location = new System.Drawing.Point(327, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 22);
            this.simpleButton4.TabIndex = 0;
            this.simpleButton4.Text = "Cancel";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(593, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 500);
            this.barDockControlBottom.Size = new System.Drawing.Size(593, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 500);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(593, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 500);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 500);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource customerReportsBindingSource;
        private nwindDataSetTableAdapters.CustomerReportsTableAdapter customerReportsTableAdapter;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private CustomFieldFilterControl customFieldFilterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;

    }
}

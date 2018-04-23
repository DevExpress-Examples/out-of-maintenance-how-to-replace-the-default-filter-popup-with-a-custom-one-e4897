using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraNavBar;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.Data.Filtering;
using DevExpress.Utils.Win;
using System.Threading;
using System.Globalization;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraPivotGrid.Customization;
using DevExpress.XtraEditors.Repository;


namespace PivotSample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            customerReportsTableAdapter.Fill(this.nwindDataSet.CustomerReports);
            pivotGridControl1.DataSource = this.customerReportsBindingSource;
            pivotGridControl1.RetrieveFields();
            pivotGridControl1.Fields["CompanyName"].Area = PivotArea.RowArea;
            pivotGridControl1.Fields["ProductName"].Area = PivotArea.RowArea;
            pivotGridControl1.Fields["OrderDate"].GroupInterval = PivotGroupInterval.DateYear;
            pivotGridControl1.Fields["OrderDate"].Area = PivotArea.ColumnArea;
            pivotGridControl1.Fields["ProductAmount"].Area = PivotArea.DataArea;
        }



        private void pivotGridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            PivotGridHitInfo hi = pivotGridControl1.CalcHitInfo(e.Location);
            if (hi.HitTest == PivotGridHitTest.HeadersArea && hi.HeaderField != null && hi.HeadersAreaInfo.HeaderHitTest == PivotGridHeaderHitTest.Filter && hi.HeaderField.Area != PivotArea.DataArea)
            {
                (e as DXMouseEventArgs).Handled = true;
                customFieldFilterControl1.Field = hi.HeaderField;
                popupControlContainer1.ShowPopup((sender as PivotGridControl).PointToScreen(e.Location));
            }
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            popupControlContainer1.HidePopup();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            customFieldFilterControl1.ApplyFilter();
            popupControlContainer1.HidePopup();
        }
    }



}
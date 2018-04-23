Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraNavBar
Imports System.IO
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.Win
Imports System.Threading
Imports System.Globalization
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraPivotGrid.Customization
Imports DevExpress.XtraEditors.Repository


Namespace PivotSample
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			customerReportsTableAdapter.Fill(Me.nwindDataSet.CustomerReports)
			pivotGridControl1.DataSource = Me.customerReportsBindingSource
			pivotGridControl1.RetrieveFields()
			pivotGridControl1.Fields("CompanyName").Area = PivotArea.RowArea
			pivotGridControl1.Fields("ProductName").Area = PivotArea.RowArea
			pivotGridControl1.Fields("OrderDate").GroupInterval = PivotGroupInterval.DateYear
			pivotGridControl1.Fields("OrderDate").Area = PivotArea.ColumnArea
			pivotGridControl1.Fields("ProductAmount").Area = PivotArea.DataArea
		End Sub



		Private Sub pivotGridControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pivotGridControl1.MouseDown
			Dim hi As PivotGridHitInfo = pivotGridControl1.CalcHitInfo(e.Location)
			If hi.HitTest = PivotGridHitTest.HeadersArea AndAlso hi.HeaderField IsNot Nothing AndAlso hi.HeadersAreaInfo.HeaderHitTest = PivotGridHeaderHitTest.Filter AndAlso hi.HeaderField.Area <> PivotArea.DataArea Then
				TryCast(e, DXMouseEventArgs).Handled = True
				customFieldFilterControl1.Field = hi.HeaderField
				popupControlContainer1.ShowPopup((TryCast(sender, PivotGridControl)).PointToScreen(e.Location))
			End If

		End Sub

		Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
			popupControlContainer1.HidePopup()
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			customFieldFilterControl1.ApplyFilter()
			popupControlContainer1.HidePopup()
		End Sub


	End Class



End Namespace
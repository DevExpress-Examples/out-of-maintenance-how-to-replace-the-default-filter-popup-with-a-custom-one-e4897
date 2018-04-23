Imports Microsoft.VisualBasic
Imports System
Namespace PivotSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim pivotGridStyleFormatCondition1 As New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Dim pivotGridGroup2 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Dim pivotGridGroup3 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Dim pivotGridGroup4 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.nwindDataSet = New Global.nwindDataSet()
			Me.customerReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.customerReportsTableAdapter = New nwindDataSetTableAdapters.CustomerReportsTableAdapter()
			Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.customFieldFilterControl1 = New PivotSample.CustomFieldFilterControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupControlContainer1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			pivotGridStyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(192))))))
			pivotGridStyleFormatCondition1.Appearance.Options.UseBackColor = True
			pivotGridStyleFormatCondition1.ApplyToCell = False
			pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
			pivotGridStyleFormatCondition1.FieldName = ""
			pivotGridStyleFormatCondition1.Value1 = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.pivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() { pivotGridStyleFormatCondition1})
			pivotGridGroup1.Caption = "Category Name"
			pivotGridGroup1.Hierarchy = "[Categories].[Category Name]"
			pivotGridGroup1.ShowNewValues = True
			pivotGridGroup2.Caption = "City"
			pivotGridGroup2.Hierarchy = "[Customers].[City]"
			pivotGridGroup2.ShowNewValues = True
			pivotGridGroup3.Caption = "Country"
			pivotGridGroup3.Hierarchy = "[Customers].[Country]"
			pivotGridGroup3.ShowNewValues = True
			pivotGridGroup4.Caption = "Products"
			pivotGridGroup4.Hierarchy = "[Products].[Products]"
			pivotGridGroup4.ShowNewValues = True
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1, pivotGridGroup2, pivotGridGroup3, pivotGridGroup4})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OLAPConnectionString = ""
			Me.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
			Me.pivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
			Me.pivotGridControl1.OptionsDataField.AreaIndex = 0
			Me.pivotGridControl1.OptionsView.RowTreeWidth = 238
			Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
			Me.pivotGridControl1.OptionsView.ShowRowGrandTotals = False
			Me.pivotGridControl1.OptionsView.ShowTotalsForSingleValues = True

			Me.pivotGridControl1.Size = New System.Drawing.Size(593, 500)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.pivotGridControl1_MouseDown);
			' 
			' pivotGridField4
			' 
			Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.pivotGridField4.AreaIndex = 0
			Me.pivotGridField4.FieldName = "Date"
			Me.pivotGridField4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.pivotGridField4.Name = "pivotGridField4"
			Me.pivotGridField4.UnboundFieldName = "pivotGridField3"
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customerReportsBindingSource
			' 
			Me.customerReportsBindingSource.DataMember = "CustomerReports"
			Me.customerReportsBindingSource.DataSource = Me.nwindDataSet
			' 
			' customerReportsTableAdapter
			' 
			Me.customerReportsTableAdapter.ClearBeforeFill = True
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.popupControlContainer1.Controls.Add(Me.customFieldFilterControl1)
			Me.popupControlContainer1.Controls.Add(Me.panelControl1)
			Me.popupControlContainer1.Location = New System.Drawing.Point(139, 189)
			Me.popupControlContainer1.Manager = Me.barManager1
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(404, 287)
			Me.popupControlContainer1.TabIndex = 3
			Me.popupControlContainer1.Visible = False
			' 
			' customFieldFilterControl1
			' 
			Me.customFieldFilterControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customFieldFilterControl1.Field = Nothing
			Me.customFieldFilterControl1.Location = New System.Drawing.Point(0, 0)
			Me.customFieldFilterControl1.Name = "customFieldFilterControl1"
			Me.customFieldFilterControl1.Size = New System.Drawing.Size(404, 261)
			Me.customFieldFilterControl1.TabIndex = 0
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton3)
			Me.panelControl1.Controls.Add(Me.simpleButton4)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 261)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(404, 26)
			Me.panelControl1.TabIndex = 2
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Dock = System.Windows.Forms.DockStyle.Right
			Me.simpleButton3.Location = New System.Drawing.Point(252, 2)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(75, 22)
			Me.simpleButton3.TabIndex = 1
			Me.simpleButton3.Text = "Ok"
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Dock = System.Windows.Forms.DockStyle.Right
			Me.simpleButton4.Location = New System.Drawing.Point(327, 2)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(75, 22)
			Me.simpleButton4.TabIndex = 0
			Me.simpleButton4.Text = "Cancel"
'			Me.simpleButton4.Click += New System.EventHandler(Me.simpleButton4_Click);
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(593, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 500)
			Me.barDockControlBottom.Size = New System.Drawing.Size(593, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 500)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(593, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 500)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(593, 500)
			Me.Controls.Add(Me.popupControlContainer1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupControlContainer1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private pivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
		Private nwindDataSet As nwindDataSet
		Private customerReportsBindingSource As System.Windows.Forms.BindingSource
		Private customerReportsTableAdapter As nwindDataSetTableAdapters.CustomerReportsTableAdapter
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private customFieldFilterControl1 As CustomFieldFilterControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton4 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

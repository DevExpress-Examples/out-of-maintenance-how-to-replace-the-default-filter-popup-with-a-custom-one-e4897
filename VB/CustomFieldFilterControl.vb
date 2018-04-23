Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid

Namespace PivotSample
	Partial Public Class CustomFieldFilterControl
		Inherits XtraUserControl
		Private Const AllItem As String = "(All)"
		Private filterItems As BindingList(Of CustomFilterItem)
		Private _field As PivotGridField
		Public Property Field() As PivotGridField
			Get
				Return _field
			End Get
			Set(ByVal value As PivotGridField)
				If _field Is value Then
					Return
				End If
				_field = value
				PopulateFilterItems()
			End Set
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub gridControl1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gridControl1.Click

		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Public Sub ApplyFilter()
			_field.PivotGrid.BeginUpdate()
			_field.FilterValues.Clear()
			If _field.FilterValues.FilterType = PivotFilterType.Included Then
				For Each item As CustomFilterItem In filterItems
					If item.Value.Equals(AllItem) Then
						Continue For
					End If
					If item.Checked =True Then
					_field.FilterValues.Add(item.Value)
					End If
				Next item
			Else
				For Each item As CustomFilterItem In filterItems
					If item.Value.Equals(AllItem) Then
						Continue For
					End If
					If item.Checked = False Then
						_field.FilterValues.Add(item.Value)
					End If
				Next item
			End If
			_field.PivotGrid.EndUpdate()

		End Sub

		Private Sub PopulateFilterItems()
			Dim values() As Object = _field.GetUniqueValues()
			Dim valuesIncluded() As Object = _field.FilterValues.ValuesIncluded
			filterItems = New BindingList(Of CustomFilterItem)()
			filterItems.Add(New CustomFilterItem() With {.Value = AllItem})
			For Each value As Object In values
				filterItems.Add(New CustomFilterItem() With {.Value = value, .Checked = valuesIncluded.Contains(value)})
			Next value
			SetAllState()
			gridControl1.DataSource = filterItems
		End Sub


		Private internalChange As Boolean = False
		Private Sub gridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView1.CellValueChanged
			If internalChange Then
				Return
			End If
			Dim value As Object = gridView1.GetRowCellValue(e.RowHandle,"Value")
			Dim state? As Boolean = CType(gridView1.GetRowCellValue(e.RowHandle, "Checked"), Boolean?)
			If value.Equals(AllItem) Then
				If state.GetValueOrDefault() = True Then
					SelsectAll()
				End If
				If state.GetValueOrDefault() = False Then
					UnselsectAll()
				End If
			Else
				SetAllState()
			End If

		End Sub

		Private Sub SelsectAll()
			internalChange = True
			gridView1.BeginDataUpdate()
			For Each item As CustomFilterItem In filterItems
				If item.Value.Equals(AllItem) Then
					Continue For
				End If
				item.Checked = True
			Next item

			gridView1.EndDataUpdate()
			internalChange = False
		End Sub
		Private Sub UnselsectAll()
			internalChange = True
			gridView1.BeginDataUpdate()
			For Each item As CustomFilterItem In filterItems
				If item.Value.Equals(AllItem) Then
					Continue For
				End If
				item.Checked = False
			Next item

			gridView1.EndDataUpdate()
			internalChange = False

		End Sub
		Private Sub SetAllState()
			filterItems(0).Checked = getAllState()

		End Sub
		Private Function getAllState() As Boolean?
			Dim hasChecked As Boolean = False
			Dim hasUnchecked As Boolean = False
			For Each item As CustomFilterItem In filterItems
				If item.Value.Equals(AllItem) Then
					Continue For
				End If
				If item.Checked = True Then
					hasChecked = True
				End If
				If item.Checked = False Then
					hasUnchecked = True
				End If

			Next item
			If hasChecked AndAlso hasUnchecked Then
				Return Nothing
			ElseIf hasChecked AndAlso (Not hasUnchecked) Then
				Return True
			Else
				Return False
			End If
		End Function


		Private Sub repositoryItemCheckEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemCheckEdit1.CheckedChanged
			gridView1.CloseEditor()
		End Sub

        Private Sub gridView1_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles gridView1.CustomColumnDisplayText
            If e.Value Is Nothing OrElse e.Value.Equals(AllItem) Then Return
            e.DisplayText = _field.GetDisplayText(e.Value)
        End Sub
    End Class
	Friend Class CustomFilterItem
		Implements INotifyPropertyChanged
		Private privateValue As Object
		Public Property Value() As Object
			Get
				Return privateValue
			End Get
			Set(ByVal value As Object)
				privateValue = value
			End Set
		End Property
		Private _checked? As Boolean
		Public Property Checked() As Boolean?
			Get
				Return _checked
			End Get
			Set(ByVal value? As Boolean)
				If _checked.Equals(value) Then
					Return
				End If
				_checked = value
				RaisePropertyChanged("Checked")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Private Sub RaisePropertyChanged(ByVal name As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
		End Sub
	End Class

End Namespace

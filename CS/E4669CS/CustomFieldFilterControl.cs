using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;

namespace PivotSample
{
    public partial class CustomFieldFilterControl : XtraUserControl
    {
        const string AllItem = "(All)";
        BindingList<CustomFilterItem> filterItems;
        PivotGridField _field;
        public PivotGridField Field
        {
            get { return _field; }
            set
            {
                if (_field == value)
                    return;
                _field = value;
                PopulateFilterItems();
            }
        }
        public CustomFieldFilterControl()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        public void ApplyFilter()
        {
            _field.PivotGrid.BeginUpdate();
            _field.FilterValues.Clear();
            if (_field.FilterValues.FilterType == PivotFilterType.Included)
                foreach (CustomFilterItem item in filterItems)
                {
                    if (item.Value.Equals(AllItem))
                        continue;
                    if (item.Checked ==true)
                    _field.FilterValues.Add(item.Value);
                }
            else
                foreach (CustomFilterItem item in filterItems)
                {
                    if (item.Value.Equals( AllItem))
                        continue;
                    if (item.Checked == false)
                        _field.FilterValues.Add(item.Value);
                }
            _field.PivotGrid.EndUpdate();

        }

        void PopulateFilterItems()
        {
            object[] values = _field.GetUniqueValues();
            object[] valuesIncluded = _field.FilterValues.ValuesIncluded;
            filterItems = new BindingList<CustomFilterItem>();
            filterItems.Add(new CustomFilterItem() { Value = AllItem });
            foreach (object value in values)
            {
                filterItems.Add(new CustomFilterItem() { Value = value, Checked = valuesIncluded.Contains(value) });
            }
            SetAllState();
            gridControl1.DataSource = filterItems;
        }


        bool internalChange = false;
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (internalChange)
                return;
            object value = gridView1.GetRowCellValue(e.RowHandle,"Value");
            bool? state = (bool?)gridView1.GetRowCellValue(e.RowHandle, "Checked");
            if (value.Equals(AllItem))
            {
                if (state == true)
                    SelsectAll();
                if (state == false)
                    UnselsectAll();
            }
            else
            {
                SetAllState();
            }

        }

        void SelsectAll()
        {
            internalChange = true;
            gridView1.BeginDataUpdate();
            foreach (CustomFilterItem item in filterItems)
            {
                if (item.Value.Equals(AllItem))
                    continue;
                item.Checked = true;
            }

            gridView1.EndDataUpdate();
            internalChange = false;
        }
        void UnselsectAll()
        {
            internalChange = true;
            gridView1.BeginDataUpdate();
            foreach (CustomFilterItem item in filterItems)
            {
                if (item.Value.Equals(AllItem))
                    continue;
                item.Checked = false;
            }

            gridView1.EndDataUpdate();
            internalChange = false;

        }
        void SetAllState()
        {
            filterItems[0].Checked = getAllState();

        }
        bool? getAllState()
        {
            bool hasChecked = false;
            bool hasUnchecked = false;
            foreach (CustomFilterItem item in filterItems)
            {
                if (item.Value.Equals(AllItem))
                    continue;
                if (item.Checked == true)
                    hasChecked = true;
                if (item.Checked == false)
                    hasUnchecked = true;

            }
            if (hasChecked && hasUnchecked)
                return null;
            else if (hasChecked && !hasUnchecked)
                return true;
            else return false;
        }


        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value == null || e.Value.Equals(AllItem))
                return;
            e.DisplayText = _field.GetDisplayText(e.Value);
        }

    }
    class CustomFilterItem:INotifyPropertyChanged
    {
        public object Value { get; set; }
        bool? _checked;
        public bool? Checked
        {
            get { return _checked; }
            set
            {
                if (_checked == value) return;
                _checked = value;
                RaisePropertyChanged("Checked");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

}

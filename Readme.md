# How to replace the default Filter Popup with a custom one.


<p>This example demonstrates how to replace the default Filter Popup with a custom one created based on the GridControl. This solution demonstrates only a basic approach, and it is possible to customize it further to achieve a custom result. The whole sample functionality can be divided into three parts:</p><br />
<p>1. We handle the PivotGridControl.MouseDown event to prevent the default filter from being displayed and show a custom one. To determine whether the end-user has clicked within a field's filter icon, we use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CalcHitInfotopic">PivotGridControl.CalcHitInfo</a> method. </p><br />
<p>2. To get information about the filter applied to a specific field, we use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_FilterValuestopic">PivotGridFieldBase.FilterValues</a> and <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_GetUniqueValuestopic">PivotGridFieldBase.GetUniqueValues</a> properties. Based on these data, we create a datasource for the GridControl in our custom filter popup.</p><br />
<p>3. To filter the PivotGrid based on selected items, we traverse through GridControl records and add corresponding values to <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_FilterValuestopic">PivotGridFieldBase.FilterValues</a>.</p>

<br/>



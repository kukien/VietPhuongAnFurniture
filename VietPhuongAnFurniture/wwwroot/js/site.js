// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function APIPost(urlStr, e) {
    $.ajax({
        url: urlStr,
        type: "POST",
        dataType: "JSON",
        data: JSON.stringify(e),
        contentType: 'application/json',
        success: function (obj) {
            // Thông báo
            DevExpress.ui.notify(obj.Msg, obj.StatusStr, 1200);
        }
    });
}
function EditCellTemplateDate(cellElement, cellInfo) {
    var time = new Date().getTime();
    var date = new Date(time);
    var dNow = date.toString();
    if (typeof (cellInfo.value) != 'undefined' && cellInfo.column.dataField == 'CreateDate') {
        dNow = cellInfo.value;
    }
    $('<div>').dxDateBox({
        value: dNow,
        disabled: true,
        displayFormat: "dd/MM/yyyy",
        width: "100%",
    }).appendTo(cellElement);

}
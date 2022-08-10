$(document).ready(function () {
    loadData();
});

//Load Data function
function loadData() {
    $.ajax({
        url: "/Logger/GetList",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Id + '</td>';
                html += '<td>' + item.UserName + '</td>';
                html += '<td>' + item.LogAction + '</td>';
                html += '<td>' + item.LogDateStr + '</td>';
                html += '<td>' + item.IpAddress + '</td>';
                html += '<td>' + item.Browser + '</td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
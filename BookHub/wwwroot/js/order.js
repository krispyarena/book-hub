var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/order/getall",
            "dataSrc": "data" // Adjust according to your API response structure
        },
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "name", "width": "15%" },
            { "data": "phoneNumber", "width": "20%" },
            { "data": "applicationuser.email", "width": "20%" },
            { "data": "orderStatus", "width": "10%" },
            { "data": "orderTotal", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="btn-group" role="group">
                        <a href="/admin/order/details?orderId=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i>&nbsp;</a>
                    </div>`
                },
                "width": "15%"
            }


        ]
    });
}
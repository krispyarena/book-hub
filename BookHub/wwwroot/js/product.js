$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/product/getall",
            "dataSrc": "data" // Adjust according to your API response structure
        },
        "columns": [
            { "data": "title", "width": "25%" },
            { "data": "author", "width": "15%" },
            { "data": "isbn", "width": "15%" },
            { "data": "listPrice", "width": "15%" },
            { "data": "category.name", "width": "15%" }
        ]
    });
}
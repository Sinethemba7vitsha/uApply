var dataTable;

$(document).ready(() => {
    var parentId = Number(document.getElementById('parentTable').getAttribute('data-parent-id'));
    loadTableData(parentId);
});

var loadTableData = (parentId) => {

    dataTable = $("#parentTable").DataTable({
        "ajax": {
            "url": `/User/Parent/Get/${parentId}`,
            "type": "GET"
        },
        "columns": [
            { "data": "fullNames", "width": "15%" },
            { "data": "surname", "width": "15%" },
            { "data": "idNumber", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            { "data": "Nationality", "width": "15%" },
            {
                "data": "id",
                "render": (data) => {
                    return `
                            <div class="d-flex justify-content-center align-items-center">
                                <a class="btn btn-info m-2" href="/Admin/Product/Upsert/${data}">Edit</a>
                                <a class="btn btn-danger m-2" onclick=Delete("/admin/product/delete/${data}")>Delete</a>
                            </div
                        `;
                }
            }
        ]
    })
}

var Delete = (url) => {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: (data) => {
                    console.log("OnDelete")
                    if (data.success) {

                        location.reload();
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message)
                    }
                }
            });
        }
    });
}
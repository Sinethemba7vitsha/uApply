var dataTable;
var towns;

$(document).ready(() => {
  /*  var parentId = Number(document.getElementById('learnerTable').getAttribute('data-parent-id'));
    loadTableData(parentId);*/
    onDomLoaded();
});

var loadTableData = (parentId) => {

    dataTable = $("#learnerTable").DataTable({
        "ajax": {
            "url": `/User/Parent/Learners/${parentId}`
        },
        "columns": [
            { "data": "fullNames", "width": "15%" },
            { "data": "surname", "width": "15%" },
            { "data": "idNumber", "width": "15%" },
            { "data": "isDisabled", "width": "15%" },
            { "data": "grade", "width": "15%" },
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

var  Delete = (url) => {
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
                    if (data.success) {
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

var onDistrictChange = () => {
    var id = +document.getElementById('District_Id').value;

    filterTownsByDistrict(id);
}

var filterTownsByDistrict = (districtId) => {

    if (!towns) return;

    var filteredTowns = towns.filter(town => town.districtId === districtId);

    populateOptions(filteredTowns, 'Learner_TownId');

}

var populateOptions = (options, elementId) => {

    let selectOptions = '';
    options.forEach(o => {
        selectOptions += `<option value='${o.id}'>${o.name}</option> \n`
    });

    document.getElementById(elementId).innerHTML = selectOptions;
}


function onDomLoaded() {
 
    api("/Admin/Town/GetTowns").then(result => {
        towns = result.data;
    }).catch(err => console.log(err))

}

var api = async (url) => {
    return new Promise((resolve, reject) => {

        const request = new XMLHttpRequest();

        request.open('GET', url, true);

        request.setRequestHeader('Content-Type', 'application/json');

        request.onload = function () {
            resolve(JSON.parse(request.response));
        };
        request.onerror = (error) => reject(error);
        request.send();

    })
}

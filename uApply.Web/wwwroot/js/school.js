document.addEventListener('DOMContentLoaded', onDomLoaded);


var onDistrictChange = () => {
    var id = +document.getElementById('District_Id').value;
    console.log('onDistrictChange')
    filterTownsByDistrict(id);
}

var filterTownsByDistrict = (districtId) => {

    if (!towns) return;

    var filteredTowns = towns.filter(town => town.districtId === districtId);

    populateOptions(filteredTowns, 'School_TownId');

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

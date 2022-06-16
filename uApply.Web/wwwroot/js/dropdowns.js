document.addEventListener('DOMContentLoaded', onDomLoaded);

var towns;
var schools;
var grades;

var filteredSchools;
var filteredGrades;

function onDomLoaded() {
    console.log('DOM Loaded....');


    api("/Admin/Town/GetTowns").then(result => {
        towns = result.data;
    }).catch(err => console.log(err))

    api("/Admin/School/GetSchools").then(result => {
        schools = result.data;
    }).catch(err => console.log(err))

    api("/Admin/Grade/GetGrades").then(result => {
        grades = result.data;
    }).catch(err => console.log(err))
}

var onDistrictChanged = () => {
    const disctrictId = +document.getElementById('District_Id').value;

    filterTownsByDistrict(disctrictId);

    enableDropdowns();
}

var enableDropdowns = () => {
    document.getElementById('Town_Id').removeAttribute("disabled");
    document.getElementById('SchoolApplication_SchoolId').removeAttribute("disabled");
    document.getElementById('SchoolApplication_GradeId').removeAttribute("disabled");
}

var onTownChanged = () => {
    const townId = +document.getElementById('Town_Id').value;

    filterSchoolsByTown(townId);
}

var onSchoolLevelChanged = () => {
    filterBySchoolLevel();
}

var filterBySchoolLevel = () => {
    const levelId = +document.getElementById('SchoolLevel_Id').value;

    if(levelId === 0) return;

    //change filtreredSchool based on selected level
    var schools = filteredSchools.filter(s => s.schoolLevelId === levelId);

    //change grades based on selected level
    filteredGrades = grades.filter(g => g.schoolLevelId === levelId);

    populateOptions(schools, 'SchoolApplication_SchoolId');
    populateOptions(filteredGrades, 'SchoolApplication_GradeId');
}



var onSchoolChanged = () => {
    const schooId = +document.getElementById('SchoolApplication_SchoolId').value;

    var schoolLeveId = (schools.filter(s => s.id === schooId)[0]).schoolLevelId;

    filterGradesBySchool(schoolLeveId);
    filterBySchoolLevel();
}

var filterTownsByDistrict = (districtId) => {

    if (!towns) return;

    var filteredTowns = towns.filter(town => town.districtId === districtId);

    populateOptions(filteredTowns, 'Town_Id');

    filterSchoolsByTown(filteredTowns[0].id);

}

var filterSchoolsByTown = (townId) => {

    if (!schools) return;

    //use global variable
    filteredSchools = schools.filter(school => school.townId === townId);

    populateOptions(filteredSchools, 'SchoolApplication_SchoolId');

    filterGradesBySchool(filteredSchools[0].schoolLevelId);
    filterBySchoolLevel();
}

var filterGradesBySchool = (schoolLevelId) => {

    if (!grades) return;

    //use global variable
    filteredGrades = grades.filter(grade => grade.schoolLevelId === schoolLevelId);

    populateOptions(filteredGrades, 'SchoolApplication_GradeId');

}

var populateOptions = (options, elementId) => {

    let selectOptions = '';
    options.forEach(o => {
        selectOptions += `<option value='${o.id}'>${o.name}</option> \n`
    });

    document.getElementById(elementId).innerHTML = selectOptions;
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
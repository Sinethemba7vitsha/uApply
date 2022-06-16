// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', onDomLoaded);

function onDomLoaded(){
console.log("hello world")

    var loggerUser = localStorage.getItem('loggedUser');

    if (loggerUser) {

        loggerUser = JSON.parse(loggerUser);

        //hide register
        document.getElementById('registerLink').style.display = "none";
        document.getElementById('loginLink').style.display = "none";

        //show logged
        document.getElementById('loggedUser').style.display = "block";
        document.getElementById('logout').style.display = "block";
        document.querySelector('#loggedUser span').innerHTML = loggerUser.username + `(${loggerUser.role})`;
        document.querySelector('#loggedUser a').setAttribute("href", loggerUser.profile);


        if (loggerUser.userId == -1) {
            document.getElementById('districtLink').style.display = "block";
            document.getElementById('townsLink').style.display = "block";

        }



    }

}

function logout() {

    var loggerUser = localStorage.getItem('loggedUser');

    if (loggerUser) {
        localStorage.setItem('loggedUser', '');
        window.location.href = "/";
    }
}


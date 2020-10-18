// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var loadFile = function (event) {
    var show = document.getElementById('show');
    show.src = URL.createObjectURL(event.target.files[0]);
    show.onload = function () {
        URL.revokeObjectURL(show.src)
    }
};

function showform() {
    var x = document.getElementById("showform");
    if (x.style.display == "block") {
        x.style.display = "none";
    }
    else
    {
        x.style.display = "block";
    }
}
var filepreview = require('filepreview');
filepreview.generate('InformationForBank.pdf', 'InformationForBank.png', function (error) {
    if (error) {
        return console.log(error);
    }
    console.log('File preview is test_preview.png');
});

//fixed navbar


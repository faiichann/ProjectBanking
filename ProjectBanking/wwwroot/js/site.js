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
var filepreview = require('filepreview');
filepreview.generate('InformationForBank.pdf', 'InformationForBank.png', function (error) {
    if (error) {
        return console.log(error);
    }
    console.log('File preview is test_preview.png');
});
//ใส่ Button
var mybutton = document.getElementById("myBtn");

// เมื่อเลื่อนลงมา 20 px โชว์ button
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        mybutton.style.display = "block";
    } else {
        mybutton.style.display = "none";
    }
}

// เมื่อคลิกปุ่ม จะเลื่อนไปด้านบน
function topFunction() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}
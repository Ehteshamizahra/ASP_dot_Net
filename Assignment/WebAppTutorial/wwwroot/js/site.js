// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//function to be called onmouseover and mouseout to change the color of "hello world"
function newColor() {
    document.getElementById("Assignment").style.color = "blue";
}

function oldColor() {
    document.getElementById("Assignment").style.color = "darkolivegreen";
}

var i = 0;
var txt = 'My favourite song';
var speed = 50;

function typeWriter() {
    if (i < txt.length) {
        document.getElementById("demo").innerHTML += txt.charAt(i);
        i++;
        setTimeout(typeWriter, speed);
    }
}

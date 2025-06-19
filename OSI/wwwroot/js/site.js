// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function VukintoshPrint(elem, header) {
    var mywindow = window.open();
    var content = header + document.getElementById("mainHead").innerHTML + document.getElementById(elem).innerHTML + "<style>body{font-family: MainFont;} h4{font-family: OSIFont;}</style>";
    mywindow.document.write(content);
    mywindow.print();
    document.body.innerHTML = realContent;
    mywindow.close();
    return true;
}

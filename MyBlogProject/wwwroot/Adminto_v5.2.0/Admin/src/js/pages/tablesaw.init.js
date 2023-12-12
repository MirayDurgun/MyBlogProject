/*
Template Name: Adminto - Responsive Bootstrap 5 Admin Dashboard
Author: CoderThemes
Website: https://coderthemes.com/
Contact: support@coderthemes.com
File: Tablesaw tables init js
*/

$( function(){
    Tablesaw.init();
    document.querySelectorAll(".tablesaw thead").forEach(function(element){
        element.classList.add("table-light");
    })
});


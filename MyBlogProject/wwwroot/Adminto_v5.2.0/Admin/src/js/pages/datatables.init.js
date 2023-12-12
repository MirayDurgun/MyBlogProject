
/*
Template Name: Uplon - Responsive Bootstrap 5 Admin Dashboard
Author: CoderThemes
Version: 2.0.0
Website: https://coderthemes.com/
Contact: support@coderthemes.com
File: Datatable init js
*/

$(document).ready(function() {

    // Default Datatable
    $('#datatable').DataTable();

    //Buttons examples
    var table = $('#datatable-buttons').DataTable({
        lengthChange: false,
        buttons: ['copy', 'excel', 'pdf']
    });

    // Key Tables

    $('#key-table').DataTable({
        keys: true
    });

    // Responsive Datatable
    $('#responsive-datatable').DataTable();

    // Multi Selection Datatable
    $('#selection-datatable').DataTable({
        select: {
            style: 'multi'
        }
    });

    table.buttons().container()
            .appendTo('#datatable-buttons_wrapper .col-md-6:eq(0)');


            $("#datatable_length select[name*='datatable_length']").addClass('form-select form-select-sm');
            $("#datatable_length select[name*='datatable_length']").removeClass('custom-select custom-select-sm');
            $(".dataTables_length label").addClass('form-label');

} );

$('.selectize-close-btn').selectize({
    plugins: ['remove_button'],
    persist: false,
    create: true,

    render: {
        item: function(data, escape) {
            return '<div>"' + escape(data.text) + '"</div>';
        }
    }
    // onDelete: function(values) {
    //     return confirm(values.length > 1 ? 'Are you sure you want to remove these ' + values.length + ' items?' : 'Are you sure you want to remove "' + values[0] + '"?');
    // }
});
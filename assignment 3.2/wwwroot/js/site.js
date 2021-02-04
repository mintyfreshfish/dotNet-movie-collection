// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var text_max = 25;
$('#count_message').html('0 / ' + text_max);

$('#text').keyup(function () {
    var text_length = $('#text').val().length;
    var text_remaining = text_max - text_length;

    $('#count_message').html(text_length + ' / ' + text_max);
});
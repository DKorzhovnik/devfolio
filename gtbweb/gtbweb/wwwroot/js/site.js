// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
BalloonEditor
	.create( document.querySelector( '#About' ) )
	.catch( error => {
		console.error( error );
	} );

// Make sure the modal does not steal the input focus (e.g. when editing a link).
// https://github.com/ckeditor/ckeditor5/issues/1147
$( '#ModalLoginForm' ).modal( {
	focus: false,
	
	// Do not show modal when innitialized.
	show: false
} );
var string = $('.str').text();
var str50 = string.substr(0,100) 
$('.str').html(str50+'...'+'<a class="readmore" href="#">readmore</a>');
$('.str').attr('data-text',string);

$('.readmore').click(function(e)
{
    e.preventDefault();
    $(this).parent().html($(this).parent().attr('data-text'))

})
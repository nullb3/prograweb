//Logica
// Puedo connectar con backend

$(document).ready(function () {
    //console.log("Jquery ready!!!");
    
    //Selectores
    $('h1').html('Texto agregado desde jquery desde etiqueta');
    $('.display-3').html('Texto agregado desde jquery desde la clase');
    $('#idTexto01').html('Texto agregado desde jquery desde el id');

    $('#idTexto01').addClass('text-danger');
    $('#idTexto01').removeClass('display-3');
    $('#idContenido').append('<h1>Agregado desde el jquery</h1>');
    $('#idContenido').prepend('<h1>Agregado desde el jquery al inicio</h1>');
    
    

    $('img').attr('src','https://upload.wikimedia.org/wikipedia/commons/7/74/Perro_cocker_mirando_acostado.jpg')
    $('img').attr('alt','Foto de un perro')
    $('img').attr('width',500)

    //$('#idImagen').hide();
    $('#idImagen').remove();

});


$(document).ready(function () {

    var informacion = $('#idTexto');

    $('.btn-primary').click(function(){
        informacion.fadeOut(1000);
    })

    $('.btn-danger').click(function(){
        informacion.fadeIn(1000);
    })

    $('.btn-warning').click(function(){
        informacion.fadeToggle(1000);
    })

});


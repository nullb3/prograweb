$(document).ready(function () {

    $('#idFormulario').validate({
        rules:{
            txtName:{ 
                required:true
            },

            txtEmail:{ 
                required:true,
                email: true
            },
            txtPassword:{ 
                required:true
              
            },
            txtPassword2:{ 
                required:true,
                equalTo: '#idPassword'
            }
        },

        messages:{
            txtName:{ 
                required:'Por favor ingrese su nombre'
            },

            txtEmail:{ 
                required:'Por favor ingrese su correo',
                email: 'Verique el formato de correo'
            },
            txtPassword:{ 
                required:'Por favor ingrese su contraseña'
              
            },
            txtPassword2:{ 
                required:'Confirme su contraseña',
                equalTo: 'Contraseña y repitición no coinciden'
            }
        },

    })

});


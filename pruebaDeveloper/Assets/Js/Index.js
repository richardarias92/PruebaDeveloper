/*function inicio() {
    /*cuando se da click al boton generar, va ejecutar el codigo en la funcion anonima
    document.getElementById("btnGenerate").addEventListener("click", function () { generatePassword(); validateForm(); }, false);
};
*/


window.onload = function () {
    var btnSend = document.getElementById('btnGenerate');

    btnSend.addEventListener("click", init);
}

function init() {
    generatePassword();
    validateForm();
}


//generacion de contraseña
function generatePassword() {
    const alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const num = "0123456789";
    let result = "";

    for (var i = 0; i < 4; i++) {

        result += alph.charAt(Math.floor(Math.random() * alph.length))
        result += num.charAt(Math.floor(Math.random() * num.length))  
    }

    return result;
};


function validateForm() {
    
    var inputList = document.querySelectorAll('#Formulario input');
    console.log(inputList);
    let error = false;
    let msgError = "";
    for (var item of inputList) {
        
        let dataReturn = validacionesFormulario(item.id, item.value);
        if (dataReturn.status != 'OK' && dataReturn.msg != "") {
            error = true;
            msgError += dataReturn.msg+'<br>';
        }

    }

    if (error) {
        document.getElementById("Error").innerHTML = msgError.substring(0, msgError.length - 4);
        document.getElementById("Error").style.display = "";
        document.getElementById("Success").style.display = "none";
    } else {
        document.getElementById("Error").innerHTML = "";
        document.getElementById("Error").style.display = "none";
        document.getElementById("Success").style.display = "";
    }

}



const formulario = document.getElementById("Formulario");


// se optiene el arreglo de todos los inputs dentro del formulario
const inputs = document.querySelectorAll('#Formulario input');

//Se ejecuta con el name del imput
const validacionesFormulario = (id, value) => {

    let success = false;
    let msg = "";

    switch (id) {
        case "codeClient":
            success = true;
            
            break;
        case "Usuario":
            if (value.substr(0, 3) == 'XMX' && value.length == 6) {
                success = true;
            }
            else {                
                msg = "Formato de campo *Usuario* es invalido  : " + value;
            }
            break;

        case "name":
            if (value.length >= 5 && value.length <= 15) {
                success = true;
            }
            else {
                msg = "El valor en el campo *Nombre* es invalido  : "+value;
            }
            break;

        case "cargo":
            if (value.length >= 5 && value.length <= 10) {
                success = true;
            }
            else {
                msg = "El valor en el campo *Cargo* es invalido  : " + value;
            }
            break;

        case "Telefono":
            if (value.length ==7 ) {
                success = true;
            }

            else
            {
                msg = "Campo *Telefono* no cumple con la cantidad de digitos necesarios : " + value;
            }
            break;

        case "Email":   
            var validEmail = /^\w+([.-_+]?\w+)*@\w+([.-]?\w+)*(\.\w{2,10})+$/;
            if ( validEmail.test(value) ) {
                console.log('si cumple emai', value);
                success = true;

            } else {
                msg = "Formato de correo es invalido  : " + value;

            }

            break;
        
    }


    return {
        'status': success ? 'OK' : 'ERROR',
        'msg' : msg
    };
}



/* se le dice al navegador que cuando se cargue la estructura del html de la pagina llame la funicion inicion */
//window.addEventListener("DOMContentLoaded", inicio, false);


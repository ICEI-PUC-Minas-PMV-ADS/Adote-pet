// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Confirmação de senha
function checkSenha() {

    var senha1 = document.getElementById("Senha").value;
    var senha2 = document.getElementById("ConfirmeSenha").value;

    if (senha1 == senha2) {
        document.getElementById("msgsenha").style.color = "green";
        document.getElementById("msgsenha").innerHTML = "Senhas confirmadas";        
    }
    else {
        document.getElementById("msgsenha").style.color = "red";
        document.getElementById("msgsenha").innerHTML = "Senhas NÃO confirmadas";
        
    }
}
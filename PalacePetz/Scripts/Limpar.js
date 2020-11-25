var senha = document.getElementById("senha");
var limpar = document.getElementById("limpar");

function Entrar() {
    if (document.getElementById("senha").value == "") {
        alert("Obrigatório informar sua senha de Gerente");
    }
    else {

    }
}
function Senha() {
    document.getElementById("limpar").style.visibility = "visible";   
}
function Limpar() {
    document.getElementById("senha").focus();
}
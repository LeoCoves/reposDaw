'use strict'

//Botones
let btnIniciar = document.getElementById("inicio");
let btnReset = document.getElementById("reset");

//Variables globales
let contador = 0;
let corriendo = false;
let temp;

//Funcion de sumar el numero
let miFuncion = function(){
    document.getElementById("cont").innerHTML = contador;
    contador++; 
}

//Evento de Iniciar
btnIniciar.addEventListener("click", function(){
    if(!corriendo)
        //setIterval realiza la funcion "miFuncion" cada 1000 milisegundos
        temp = setInterval(miFuncion, 1000)
        corriendo = true;
})

//Evento de Reset
btnReset.addEventListener("click", function(){
    if(corriendo)
        //Deja de realizar la funcion cada 1 segundo
        clearInterval(temp)
        contador = 0;
        document.getElementById("cont").innerHTML = 0;
        corriendo = false;
})






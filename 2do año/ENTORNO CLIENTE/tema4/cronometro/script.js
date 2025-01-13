'use strict'

//Botones
let btnIniciar = document.getElementById("inicio");
let btnReset = document.getElementById("reset");

//Variables globales
let contador = 0;
let corriendo = false;
let temp;

//Evento de Iniciar
btnIniciar.addEventListener("click", () =>{
    if(!corriendo){
        //setIterval realiza la funcion "miFuncion" cada 1000 milisegundos
        temp = setInterval(()=>{
            document.getElementById("cont").innerHTML = contador;
            contador++; 
        }, 1000);
        corriendo = true;
        btnIniciar.textContent = "Parar";
    }
    else{
        clearInterval(temp);
        btnIniciar.textContent = "Iniciar";
        corriendo = false;
    }
})

//Evento de Reset
btnReset.addEventListener("click", () =>{
    if(corriendo)
        //Deja de realizar la funcion cada 1 segundo
        clearInterval(temp);
        corriendo = false;
        btnIniciar.textContent = "Iniciar";

    contador = 0;
    document.getElementById("cont").innerHTML = 0;
})






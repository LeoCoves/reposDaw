// Ejercicio 1: Completa la función
function guardarNombre() {
    console.log("Pulsando")
    let nombre = document.getElementById("nombre").value;
    localStorage.setItem("NombreStorage", nombre);
    document.getElementById("mensaje").textContent = `Nombre ${nombre} guardado correctamente`;
}

window.onload = function(){
    if(localStorage.getItem("NombreStorage")){
        document.getElementById("mensaje").textContent = "Bienvenido " + localStorage.getItem("NombreStorage");
    }
}



// // Ejercicio 2: Completa la función
// function obtenerDatos() {
//     let API_URL = `https://suhhtqjccd.execute-api.eu-west-1.amazonaws.com/latest/leocoves`;
//     let box = document.getElementById("resultado");
//     let gastos = [];

//     let promise = fetch(API_URL);

//     promise.then(res => res.json()
//     ).then((res)=>{
//         JSON.stringify(res);
//         gastos = res;
//     }).catch((error)=>{
//         error = "Error";
//         console.log(error);
//     })

//     console.log(gastos);
// }

// Ejercicio 3: Completa la función
function cambiarColor() {
    let colores = ["green", "red", "yellow", "brown"];
    let colorActual = document.getElementById("cuadro").style.backgroundColor;
    let nuevoColor = colores[Math.floor(Math.random() * colores.length)];
    document.getElementById("cuadro").style.backgroundColor = nuevoColor;
}

// Ejercicio 4: Completa la función
function ejecutarPromesa() {
    // Tu código aquí
}
let miBoton1 = document.getElementById("btn1")
let miBoton2 = document.getElementById("btn2")
let miBoton3 = document.getElementById("btn3")

let miImagen = document.getElementById("img1");

miBoton1.addEventListener("click", function()
{
        
        if(miImagen.alt == "imgUno")
        {
            miImagen.src = "img/playa.jpg"
            miImagen.alt = "imgDos"
        }
        else
        {
            miImagen.src ="img/bosque.png"
            miImagen.alt = "imgUno"
        }
})

miBoton2.addEventListener("click", function()
{
    let Titulo = document.getElementById('title').innerHTML = "Prueba de cambio"
})

miBoton3.addEventListener("click", function()
{
    let Parrafo = document.getElementById('parrafo').innerHTML = "Prueba de cambio"
})
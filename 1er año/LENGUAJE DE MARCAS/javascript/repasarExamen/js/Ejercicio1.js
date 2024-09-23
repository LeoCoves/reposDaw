let cambiarImagen = document.getElementById('btn1');
let cambiarTitulo = document.getElementById('btn2');
let cambiarParrafo = document.getElementById('btn3');

cambiarImagen.addEventListener("click", function()
{
    let miImagen = document.getElementById('img');

    if (miImagen.alt == "imgUno")
    {
        miImagen.src = "img/paisaje2.jpg"
        miImagen.alt = "imgDos"
    }
    else
    {
        miImagen.src = "img/paisaje1.jpg"
        miImagen.alt = "imgUno"
    }
})

cambiarTitulo.addEventListener("click", function()
{
    let titulo = document.getElementById('h1').innerHTML = "Titulo cambiado"
})

cambiarParrafo.addEventListener("click", function()
{
    let parrafo = document.getElementById('parrafo').innerHTML = "Parrafo cambiado"
})
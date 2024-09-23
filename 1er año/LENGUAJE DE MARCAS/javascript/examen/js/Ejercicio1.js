let boton1 = document.getElementById('btn1');
let boton2 = document.getElementById('btn2')
let boton3 = document.getElementById('btn3')

let parrafo = document.getElementById('parrafo1')

boton1.addEventListener("click", function()
{
    let elemento1 = document.getElementsByTagName('button')
    let numBotones

    for(let i = 1; i <= elemento1.length; i++)
    {
        numBotones = i;
    }
    if(numBotones == null)
    {
        numBotones = 0
    }

    ////////
    let elemento2 = document.getElementsByTagName('a')
    let numEnlaces

    for(let i = 1; i <= elemento2.length; i++)
    {
        numEnlaces = i;
    }
    if(numEnlaces == null)
    {
        numEnlaces = 0
    }

    /////////
    let elemento3 = document.getElementsByTagName('h1')
    let numTitulos

    for(let i = 1; i <= elemento3.length; i++)
    {
        numTitulos = i
    }
    if(numTitulos == null)
    {
        numTitulos = 0
    }

    parrafo.innerHTML = "Numero de botones es de " + numBotones + " el numero de enlaces es: " + numEnlaces+ "\n y el numero de titulos son:  " + numTitulos;

})


boton2.addEventListener("click", function()
{

    let tituloNuevo = document.createElement('h1')
    tituloNuevo.innerHTML = "Nuevo Titulo"
    document.body.appendChild(tituloNuevo)
})

boton3.addEventListener("click", function()
{
    let google = document.getElementById('enl1')
    let wiki = document.getElementById('enl2')

    if(google.href == "https://www.google.es/")
    {
        google.href = "https://es.wikipedia.org/"
        wiki.href = "https://www.google.es/"
        alert("intercambiados")
    }
    else
    {
        google.href = "https://www.google.es/"
        wiki.href = "https://es.wikipedia.org/"
        alert("intercambiados")
    }
})

let input = document.getElementById('inputBox')
let parrafo = document.createElement('p')
parrafo.innerHTML = "La longitud del texto es " + document.getElementById('inputBox').maxLength
document.body.appendChild(parrafo)
parrafo.id = "parrafoDinamico"

input.addEventListener("keyup", function()
{
    document.getElementById('parrafoDinamico').innerHTML = "Los caracteres disponibles son " + (document.getElementById('inputBox').maxLength - document.getElementById('inputBox').value.length )
})
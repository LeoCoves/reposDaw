let parrafo = document.createElement("p");
parrafo.innerHTML = "La longitud del texto es " + document.getElementById("textoEscrito").maxLength
parrafo.id = "parrafoDinamico"
document.body.appendChild(parrafo)

document.getElementById("textoEscrito").addEventListener("keyup", function()
{
    document.getElementById("parrafoDinamico").innerHTML = "Los caracteres disponibles son " + (document.getElementById("textoEscrito").maxLength - document.getElementById("textoEscrito").value.length)
})
let botonAgregar = document.getElementById('agregarElemento')
let botonEliminar = document.getElementById('eliminarUltimoElemento')


botonAgregar.addEventListener("click", function()
{
    let lista = document.getElementById('miLista')
    let contenidoElemento = document.getElementById("inputText").value
    let nuevoElemento = document.createElement('li')

    let textoElemento = document.createTextNode(contenidoElemento)
    nuevoElemento.appendChild(textoElemento)
    lista.appendChild(nuevoElemento)
})


botonEliminar.addEventListener("click", function()
{
        let ultimoElemento = document.getElementById('miLista').lastChild
        document.getElementById('miLista').removeChild(ultimoElemento)
})
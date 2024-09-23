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
    let lista = document.getElementById('miLista')
    let contenidoElemento = document.getElementById('inputText').value

    // if(elementos.length > 0)
    // {
        let elementos = document.getElementsByTagName('li')
        let ultimoElemento = lista.lastChild(elementos)
        lista.removeChild(ultimoElemento)
    // }
    // else
    // {
    //     alert("No hay ningun elemento para eliminar")
    // }
})
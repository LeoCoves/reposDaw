let agregarElemento = document.getElementById('btn1');
let eliminarElemento = document.getElementById('btn2');

agregarElemento.addEventListener("click", function()
{
    let miLista = document.getElementById('lista');
    let contenidoElemento = document.getElementById('inputBox').value;
    let nuevoElemento = document.createElement('li');

    let textoElemento = document.createTextNode(contenidoElemento);
    nuevoElemento.appendChild(textoElemento)
    miLista.appendChild(nuevoElemento)
})

eliminarElemento.addEventListener("click", function()
{
    let miLista = document.getElementById('lista')
    let ultimoElemento = document.getElementById('lista').lastChild
    miLista.removeChild(ultimoElemento)
})
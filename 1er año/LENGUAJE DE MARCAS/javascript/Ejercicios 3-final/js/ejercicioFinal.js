let cambiarTexto = document.getElementById('btn1')
let borrarFila = document.getElementById('btn2')
let insertarFila = document.getElementById('btn3')

insertarFila.addEventListener("click", function()
{
    let cantidadColumnas = prompt('Cuantas columnas quieres?');
    
    if(cantidadColumnas <= 0)
    {
        alert('Introduce un numero positivo')
    }
    else
    {
        crearFilas(cantidadColumnas);
    }
})


function crearFilas(cantidadColumnas)
{
    let tabla = document.getElementById('tabla')

    let filas = document.createElement('tr')

    for(let i = 1; i <= cantidadColumnas; i++)
    {
        let columnas = document.createElement('td')
        columnas.innerHTML = "Celda" + i;
        filas.appendChild(columnas);
    }

    tabla.appendChild(filas)
}

borrarFila.addEventListener("click", function()
{
    let filaBorrada = prompt('Que fila quieres borrar?')

    if(filaBorrada <= 0)
    {
        alert('Introduce un numero positivo')
    }
    else
    {
        deleteFila(filaBorrada);
    }
})

function deleteFila(filaBorrada)
{
    tabla.deleteRow(filaBorrada)
}

cambiarTexto.addEventListener("click", function()
{
    let texto = document.getElementById('inputBox').value;

    if(texto.length == 0)
    {
        alert("No has introducido nada");
    }
    else
    {
        changeText(texto);
    }
})

function changeText(texto)
{
    let filaTexto = prompt('¿En qué fila desea introducir el texto?');
    let columnaTexto = prompt('¿En qué columna?');
    let tabla = document.getElementById('tabla');

    if ((filaTexto >= 0 && filaTexto < tabla.rows.length) && (columnaTexto > 0 && columnaTexto <= tabla.rows[filaTexto].cells.length))
    {
        tabla.rows[filaTexto].cells[columnaTexto - 1].textContent = texto;
    } 
    else 
    {
        alert('Fila o columna no válida. Introduzca valores válidos.');
    }
}

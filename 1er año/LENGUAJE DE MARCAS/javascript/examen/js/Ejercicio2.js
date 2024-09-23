let parrafo = document.getElementById('parrafo')

const numerito = Math.floor(Math.random()*30)+1
alert (numerito)



for(let i = 1; i <= numerito; i++)
{
    let texto = document.createElement('p')
    texto.innerHTML = "Hola este es el parrafo " + i;
    parrafo.appendChild(texto)
}
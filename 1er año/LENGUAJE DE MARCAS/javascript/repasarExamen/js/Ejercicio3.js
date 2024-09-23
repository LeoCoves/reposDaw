let iniciarContador = document.getElementById('iniciar');
let detenerContador = document.getElementById('detener');
let valorContador = 0;
let contador;

iniciarContador.addEventListener("click", function()
{
    contador = setInterval(function()
    {
        valorContador++;
        document.getElementById('contador').textContent = valorContador;
    }, 1000)
})

detenerContador.addEventListener("click", function()
{
    clearInterval(contador)
})


let iniciar = document.getElementById('iniciar');
let detener = document.getElementById('detener')
let valorContador = 0;
let contador;

iniciar.addEventListener("click", function()
{
    contador = setInterval(function()
    {
        valorContador++
        document.getElementById('contador').textContent = valorContador
    }, 1000)

    
})

detener.addEventListener("click", function()
{
    clearInterval(contador)
})
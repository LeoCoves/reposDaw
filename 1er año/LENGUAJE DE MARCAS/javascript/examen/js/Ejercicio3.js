
let iniciar = document.getElementById('iniciar');
let detener = document.getElementById('detener')
let imagen = document.getElementById('imagen')
let contador = 0;

iniciar.addEventListener("click", function()
{
    contador = setInterval(function()
    {
        if(imagen.alt == "ESP")
        {
            imagen.src = "img/francia.png"
            imagen.alt = "FRA"
            document.body.style.backgroundColor = "blue"
        }
        else
        {
            imagen.src ="img/españa.png"
            imagen.alt = "ESP"
            document.body.style.backgroundColor = "red"
        }
        
    }, 3000)

    
})

detener.addEventListener("click", function()
{
    clearInterval(contador)
    document.body.style.backgroundColor = "red"
    
    if(imagen.alt == "FRA")
    {
        imagen.src ="img/españa.png"
        imagen.alt = "ESP"
    }
})
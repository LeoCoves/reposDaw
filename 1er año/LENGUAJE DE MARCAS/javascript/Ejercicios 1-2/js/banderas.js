let España = document.getElementById('txtEspaña')
let Marruecos = document.getElementById('txtMarruecos')
let Francia = document.getElementById('txtFrancia')
let Ninguno = document.getElementById('txtNinguno')

España.addEventListener("mouseover", function()
{
    document.getElementById('imagenes').src = 'D:/DAW grado superior/1DAW/LENGUAJE DE MARCAS/javascript/Ejercicios 1-2/img/españa.png'
})

Marruecos.addEventListener("mouseover", function()
{
    document.getElementById('imagenes').src = 'D:/DAW grado superior/1DAW/LENGUAJE DE MARCAS/javascript/Ejercicios 1-2/img/marruecos.png'
})

Francia.addEventListener("mouseover", function()
{
    document.getElementById('imagenes').src = 'D:/DAW grado superior/1DAW/LENGUAJE DE MARCAS/javascript/Ejercicios 1-2/img/francia.png'
})

Ninguno.addEventListener("mouseover", function()
{
    document.getElementById('imagenes').src = 'D:/DAW grado superior/1DAW/LENGUAJE DE MARCAS/javascript/Ejercicios 1-2/img/blanco.png'
})
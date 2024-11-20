let chistes = [
    {
	enunciado: "¿Qué le dice un bit a otro?",
	respuesta: "Nos vemos en el bus."
    },
    {
	enunciado: "¿Qué es un terapeuta?",
	respuesta: "1024 GigaPeutas."
    },
    {
	enunciado: "¿Cuántos programadores hacen falta para cambiar una bombilla?",
	respuesta: "Ninguno, porque es un problema de hardware."
    }
]

//Opcion 1

let divChistes = document.createElement('div');
    divChistes.id = "Chistes";
    document.body.appendChild(divChistes);

chistes.forEach(chiste => { 
    let divEnunciado = document.createElement('div');
    divEnunciado.textContent = chiste.enunciado
    divChistes.appendChild(divEnunciado);

    let btnRespuesta = document.createElement('button');
    btnRespuesta.className = "btn";
    btnRespuesta.textContent = "Ver Respuesta";

    btnRespuesta.addEventListener("click", function(){
        alert(chiste.respuesta);
    });

    divChistes.appendChild(btnRespuesta);
});


//Opcion 2 ()
// chistes.forEach((chiste, index) => { 
//     let divChiste = document.createElement('div');
//     divChiste.className = "Chiste" + (index + 1);
//     document.body.appendChild(divChiste);

//     let divEnunciado = document.createElement('div');
//     divEnunciado.textContent = chiste.enunciado;
//     divChiste.appendChild(divEnunciado);

//     let btnEnunciado = document.createElement('button');
//     btnEnunciado.textContent = "Ver Respuesta";

//     btnEnunciado.addEventListener("click", function(){
//         verRespuesta(index);
//     });
//     divChiste.appendChild(btnEnunciado);
// });

// function verRespuesta(index){
//     let chiste = chistes[index];
//     alert(`${chiste.respuesta}`);
// }



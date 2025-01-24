const API_URL = "http://127.0.0.1:5500/Ejercicio2/archivo.json";

let promise = fetch(API_URL);

promise.then(res => res.json()
    ).then(data =>{
        console.log(data);
        data.forEach(element => {
            let nombreCompleto = document.createElement("h1");
            nombreCompleto.textContent = "Usuario: " + element.apellido + ", " + element.nombre + ".";
            document.body.appendChild(nombreCompleto);
        });
    }).catch(error => {
        error = "Error"
        console.log(error)
    })
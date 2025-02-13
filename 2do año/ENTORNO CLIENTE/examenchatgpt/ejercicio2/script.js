
let API_URL = "http://127.0.0.1:5500/examenchatgpt/ejercicio2/datos.json"

let promise = fetch(API_URL);
promise.then(res => res.json()
    ).then(data=>{
        console.log(data);
        data.forEach(item => {
            let text = document.createElement("p");
            text.textContent = `Usuario: ${item.apellidos}, ${item.nombre}`;
            document.body.appendChild(text);
        });
    }).catch(error => console.log(error))
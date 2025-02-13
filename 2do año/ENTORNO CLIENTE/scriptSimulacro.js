// js/app.js
let idCounter = 0;
let tareas = [];

/**
 * FUNCIÓN CONSTRUCTORA DEL OBJETO TAREA
 * @param {string} descripcion - La descripción de la tarea.
 * @param {string} fecha - La fecha de la tarea en formato ISO (YYYY-MM-DD).
 * @property {number} id - El identificador único de la tarea.
 * @property {string} descripcion - La descripción de la tarea.
 * @property {number} fecha - La fecha de la tarea en formato timestamp.
 * @property {boolean} completada - Indica si la tarea está completada (inicialmente false).
 * @method modificar - Método para modificar la descripción y la fecha de la tarea.
 * @param {string} nuevaDesc - La nueva descripción de la tarea.
 * @param {string} nuevaFecha - La nueva fecha de la tarea en formato ISO (YYYY-MM-DD).
 */
function Tarea(descripcion, fecha, completada = false) {
    
    this.descripcion = descripcion;
    this.fecha = Date.parse(fecha);
    if(isNaN(Date.parse(fecha))){
        this.fecha = Date.now();
    }
    this.completada = completada;

    // this.modificar(nuevaDesc, nuevaFecha) = function(){
        
    //     if(nuevaFecha != undefined){
    //         this.descripcion = nuevaDesc;
    //     }

    //     if(!isNaN(Date.parse(nuevaFecha))){
    //         this.fecha = nuevaFecha;
    //     }
    // }
}

/**
 * FUNCIÓN AGREGAR TAREA
 * @param {string} descripcion - La descripción de la tarea.
 * @param {string} fecha - La fecha de la tarea en formato ISO (YYYY-MM-DD).
 * @returns {void} - No retorna ningún valor.
 */
function agregarTarea(descripcion, fecha) {
    let newTarea = new Tarea(descripcion, fecha);
    idCounter++;
    newTarea.id = idCounter;
    tareas.push(newTarea);
}

/**
 * MANEJO DEL EVENTO DOMContentLoaded (YA SE HA CARGADO LA PÁGINA)
 * - Agregar eventos a los botones con id:
 *   - obtener-fecha: al hacer clic llamará a la función obtenerFechaActual.
 *   - borraStorage: al hacer clic borrará el localStorage y el array tareas.
 * - Seleccionar el formulario con id formulario-tarea que agrega tarea nueva.
 * - Añadir evento submit al formulario y cancelar.
 * - Añadir funciones manejadoras para los botones con id cargar-api y guardar-api.
 * - Cargar los datos guardados en localStorage en la variable tareas si los hay.
 * - Llamar a renderizarTareas.
 */
document.addEventListener('DOMContentLoaded', () => {
    obtenerFechaActual();
    
    document.getElementById("borraStorage").addEventListener("click", function(){
        tareas = [];
        localStorage.clear();
        renderizarTareas();
    })
    
    
    let contenedor = document.getElementById("contenedor-principal");
    let form = contenedor.querySelector("form");

    form.addEventListener("submit", function(evento){
        evento.preventDefault();

        let descripcion = form.querySelector("#descripcion-tarea").value;
        let fecha = form.querySelector("#fecha-tarea").value;
        agregarTarea(descripcion, fecha);

        guardarEnLocalStorage();
        renderizarTareas();
    })

    let tareasRecuperadas = [];
    if(localStorage.getItem("tareas")){
        tareasRecuperadas = JSON.parse(localStorage.getItem("tareas"));
    }



    for(let g of tareasRecuperadas){
        let tareaRehidratada = new Tarea();

        Object.assign(tareaRehidratada, g);

        tareas.push(tareaRehidratada);
    }

    renderizarTareas();
    
});

/**
 * FUNCIÓN RENDERIZAR TAREAS
 * - Seleccionar el ul con id lista-tareas.
 * - Si el array tareas está vacío, añadir un párrafo al ul que diga "No hay tareas pendientes".
 * - Si no está vacío, recorrer el array tareas.
 * - Por cada tarea, crear un li con clase flex.
 * - Si la tarea está completada, añadir la clase tarea-completada al div con clase contenido-tarea.
 * - Añadir al li el contenido:
 *   - Un div con clase contenido-tarea que contendrá:
 *     - Un h3 con clase descripcion-tarea con la descripción de la tarea.
 *     - Un p con la fecha de la tarea formateada con la función formatearFecha.
 *   - Un div con clase acciones-tarea que contendrá:
 *     - Un botón con clase editar.
 *     - Un botón con clase borrar.
 * - Añadir un evento clic al h3 con clase descripcion-tarea.
 * - Al hacer clic, cambiará el valor de la propiedad completada de la tarea y se guardará en localStorage.
 * - Llamar a renderizarTareas.
 * - Crear un objeto EditarHandle que tendrá dos propiedades: tarea y li.
 * - Al hacer clic en el botón editar, se creará un formulario de edición con la descripción y fecha de la tarea.
 * - Al hacer clic en el botón editar del formulario, se modificará la tarea y se guardará en localStorage.
 * - Al hacer clic en el botón cancelar del formulario, se cerrará el formulario.
 * - Al hacer clic en el botón borrar, se eliminará la tarea del array tareas y se guardará en localStorage.
 * - Al finalizar el bucle, añadir el li al ul.
 * @returns {void} - No retorna ningún valor.
 */
function renderizarTareas() {
    //Identificamos el ul
    let listaTareas = document.getElementById("lista-tareas");

    listaTareas.innerHTML = "";

    if(tareas.length == 0){
        let p = document.createElement("p");
        p.textContent = "No hay tareas pendientes"
        listaTareas.appendChild(p);
    }
    else{
        tareas.forEach(tarea => {
            //Creamos el item li
            let li = document.createElement("li");
            li.className = "flex";

             //Creamos el primer div del contenido de la tarea
             let divContent = document.createElement("div");
             divContent.className = "contenido-tarea";

            if(tarea.completada == true){
                divContent.className = "contenido-tarea tarea-completada";
            }

            
            //Creamos el titulo de la tarea
            let tareaTitle = document.createElement("h3");
            tareaTitle.className = "tarea-title";
            tareaTitle.textContent = tarea.descripcion; 

            tareaTitle.addEventListener("click", function(){
                if(tarea.completada == false){
                    divContent.className = "contenido-tarea tarea-completada";
                    tarea.completada = true;
                }
                else{
                    divContent.className = "contenido-tarea";
                    tarea.completada = false;
                }
            })

            let tareaDate = document.createElement("p");
            tareaDate.className = "tarea-date";
            tareaDate.textContent = new Date(tarea.fecha).toLocaleString(); 

            divContent.appendChild(tareaTitle);
            divContent.appendChild(tareaDate);

            let divAction = document.createElement("div");
            divAction.className = "acciones-tarea";
            
            let buttonEdit = document.createElement("button");
            buttonEdit.className = "editar";
            buttonEdit.textContent = "Editar";

            let editarManejador = new EditarHandle();
            editarManejador.tarea = tarea;
            editarManejador.li = li;
            buttonEdit.addEventListener("click", editarManejador)

            let buttonDelete = document.createElement("button");
            buttonDelete.className = "eliminar";
            buttonDelete.textContent = "Eliminar";

            let borrarManejador = new DeleteHandle();
            borrarManejador.tarea = tarea;
            buttonDelete.addEventListener("click", borrarManejador);


            divAction.appendChild(buttonEdit);
            divAction.appendChild(buttonDelete);

            li.appendChild(divContent);
            li.appendChild(divAction);
            listaTareas.appendChild(li);
        });
    }
}

/**
 * FUNCIÓN MANEJADORA EDITAR (DEBE SER UNA FUNCIÓN CONSTRUCTORA)
 * @param {Event} event - El evento que desencadena la edición.
 * @property {Object} tarea - La tarea que se está editando.
 * @property {HTMLElement} li - El elemento li que contiene la tarea.
 * @method iniciarEdicion - Método para iniciar la edición de la tarea.
 * @method guardarEdicion - Método para guardar los cambios de la tarea.
 * @method cancelarEdicion - Método para cancelar la edición.
 */
function EditarHandle() {
    this.handleEvent = function(event){
        //Obtenemos plantilla y guardamos el form en una variable
        let plantillaFormulario = document.getElementById("plantilla-edicion").content.cloneNode(true);
        var formulario = plantillaFormulario.querySelector("form");

        let tarea = this.tarea;
        let li = this.li;

        li.appendChild(formulario);

        formulario.addEventListener("submit", function(){
            event.preventDefault();

            tarea.descripcion = formulario.querySelector(".editar-descripcion").value;
            tarea.fecha = Date.parse(formulario.querySelector(".editar-fecha").value);

            formulario.remove();
            renderizarTareas();
        })

        formulario.querySelector(".cancelar-edicion").addEventListener("click", function(){
            event.preventDefault();
            formulario.remove();
            renderizarTareas();
        })
    }
}

function DeleteHandle(){
    this.handleEvent = function(event){
        event.preventDefault();
        
        let pos = tareas.findIndex(t => t.id === this.tarea.id);

        if(pos !== -1){
            tareas.splice(pos, 1);
            guardarEnLocalStorage();
            renderizarTareas();
        }
    }
}

/**
 * FUNCIÓN QUE DEVUELVE LA FECHA FORMATEADA COMO DD/MM/YYYY
 * @param {string} fecha - La fecha en formato ISO (YYYY-MM-DD).
 * @returns {string} - La fecha formateada como DD/MM/YYYY.
 */
function formatearFecha(fecha) {
    return new Date(fecha).toLocaleDateString('es-ES').slice(0, 10).replace('T', ' ');
}

/**
 * FUNCIÓN QUE GUARDA ARRAY TAREAS EN LOCALSTORAGE
 * @returns {void} - No retorna ningún valor.
 */
function guardarEnLocalStorage() {
    localStorage.setItem("tareas", JSON.stringify(tareas));
}

/**
 * Función ASYNC para cargar tareas desde una API
 * @async
 * @returns {void} - No retorna ningún valor.
 * @throws {Error} - Si ocurre un error al cargar las tareas desde la API.
 */
async function cargarTareasDesdeAPI() {
    // TO DO: Implementar la función cargarTareasDesdeAPI
    try {
        let API_URL = "https://jsonplaceholder.typicode.com/todos";

        let promise = fetch(API_URL);
        promise.then(res => res.json()
            ).then((data)=>{
                data.slice(0, 5);
                for(let tarea of data.slice(0,5)) {
                    console.log(data);
                    
                    let tareaRehidratada = new Tarea(tarea.title, Date.now());
                    tareas.push(tareaRehidratada);
                    renderizarTareas();
                }
        }).catch((error)=>{
                error = "Error";
                console.log(error);
        })
    } catch (error) {
        error = "Error";
        console.log("Error");
    }
}

document.getElementById("cargar-api").addEventListener("click", cargarTareasDesdeAPI)

/**
 * Función para guardar tareas en una API
 * @async
 * @returns {void} - No retorna ningún valor.
 * @throws {Error} - Si ocurre un error al guardar las tareas en la API.
 */
async function guardarTareasEnAPI() {
    // TO DO: Implementar la función guardarTareasEnAPI
    try {
        let API_URL = "https://jsonplaceholder.typicode.com/todos";

        let promise = fetch(API_URL,{
            method: "POST",
            body: JSON.stringify(tareas)
        });

        promise.then(alert("Enviada a la api")
        ).catch((error)=>{
                error = "Error";
                console.log(error);
        })
      
    } catch (error) {
        error = "Error";
        console.log(error);
    }
}

document.getElementById("guardar-api").addEventListener("click", guardarTareasEnAPI)


/**
 * Función para obtener la fecha y hora actual desde una API
 * @async
 * @returns {void} - No retorna ningún valor.
 * @throws {Error} - Si ocurre un error al obtener la fecha y hora actual.
 */
async function obtenerFechaActual() {
    // TO DO: Implementar la función obtenerFechaActual
    try {
        let API_URL = "https://worldtimeapi.org/api/ip";
        let promise = fetch(API_URL);
        promise.then(res=>res.json()
        ).then(data=>{

            console.log(data.datetime);
        }
        ).catch((error)=>{
            error = "Error";
            console.log(error);
        })
    } catch (error) {
        error = "Error";
        console.log(error);
    }
}

document.getElementById("obtener-fecha").addEventListener("click", obtenerFechaActual)

'use strict'

let idEmpleado = 0;
let empleados = [];

function Empleado(nombre, apellidos, nif, edad, puesto, salario, antigüedad){

    this.nombre = nombre;
    this.apellidos = apellidos;
    this.nif = nif;
    this.edad = edad;
    this.puesto = puesto;
    this.salario = salario;
    this.antigüedad = antigüedad;

}

function anyadirEmpleado(empleado){
    empleado.id = idEmpleado;
    idEmpleado++;
    empleados.push(empleado);
}

function muestraWeb(){
    let divEmple = document.getElementById("divEmple");

    let titEmp = document.createElement("h1");
    titEmp.id = "tituloH1";
    titEmp.textContent = "Listado de Empleados";
    divEmple.appendChild(titEmp);

    let listEmp = document.createElement("ol");
    listEmp.id = "listaOrd";
    listEmp.className = "rounded-list";
    
    empleados.forEach(empleado => {
        let liEmp = muestraEmpleado(empleado);
        listEmp.appendChild(liEmp);
    });
    
    divEmple.appendChild(listEmp);
}

function muestraEmpleado(empleado){
    let liEmp = document.createElement("li");
    liEmp.id = "li" + empleado.id;

    let divEmp = document.createElement("div");
    divEmp.className = "empleado";
    divEmp.id = empleado.id;
    
    let pNomEmp = document.createElement("p");
    pNomEmp.textContent = empleado.nombre + " " + empleado.apellidos;
    
    let pNifEmp = document.createElement("p");
    pNifEmp.textContent = "NIF: " + empleado.nif;
    
    let pEdadEmp = document.createElement("p");
    pEdadEmp.textContent = "Edad: " + empleado.edad;
    
    let pPueEmp = document.createElement("p");
    pPueEmp.textContent = "Puesto: " + empleado.puesto;
    
    let pSalEmp = document.createElement("p");
    pSalEmp.textContent = "Salario: " + empleado.salario;
    
    let pAntEmp = document.createElement("p");
    pAntEmp.textContent = "Antigüedad: " + empleado.antigüedad;

    let btnEditar = document.createElement("button");
    btnEditar.id = "bEdit" + empleado.id;
    btnEditar.textContent = "Editar";

    let editarBotonManejador = new editarHandle();
    editarBotonManejador.empleado = empleado;
    btnEditar.addEventListener("click", editarBotonManejador);

    let btnBorrar = document.createElement("button");
    btnBorrar.id = "bBorrow" + empleado.id;
    btnBorrar.textContent = "Borrar";
    
    let borrarBotonManejador = new borrarHandle();
    borrarBotonManejador.empleado = empleado;
    btnBorrar.addEventListener("click", borrarBotonManejador); 


    divEmp.appendChild(pNomEmp);
    divEmp.appendChild(pNifEmp);
    divEmp.appendChild(pEdadEmp);
    divEmp.appendChild(pPueEmp);
    divEmp.appendChild(pSalEmp);
    divEmp.appendChild(pAntEmp);
    divEmp.appendChild(btnEditar);
    divEmp.appendChild(btnBorrar);

    liEmp.appendChild(divEmp);

    return liEmp;
}

function editarHandle(){
    this.handleEvent = function(){
        let nombre = prompt("Introduzca el nombre", this.empleado.nombre);
        let apellidos = prompt("Introduzca los apellidos", this.empleado.apellidos);
        let nif = prompt("Introduzca el nif", this.empleado.nif);
        let edad = prompt("Introduzca la edad", this.empleado.edad);
        let puesto = prompt("Introduzca el puesto", this.empleado.puesto);
        let salario = prompt("Introduzca el salario", this.empleado.salario);
        let antigüedad = prompt("Introduzca la antigüedad", this.empleado.antigüedad);

        this.empleado.nombre = nombre;
        this.empleado.apellidos = apellidos;
        this.empleado.nif = nif;
        this.empleado.edad = Number(edad);
        this.empleado.puesto = puesto;
        this.empleado.salario = Number(salario);
        this.empleado.antigüedad = Number(antigüedad);

        document.getElementById("divEmple").innerHTML = "";
        muestraWeb();
    }
}

function borrarHandle(){
    this.handleEvent = function(){
        let pos = this.empleado.id;
        empleados.splice(pos, 1);

        document.getElementById("divEmple").innerHTML = "";
        muestraWeb();
    }
}

function nuevoEmpleadoWeb(){
    let nombre = prompt("Introduzca el nombre");
    let apellidos = prompt("Introduzca los apellidos");
    let nif = prompt("Introduzca el nif");
    let edad = prompt("Introduzca la edad");
    let puesto = prompt("Introduzca el puesto");
    let salario = prompt("Introduzca el salario");
    let antigüedad = prompt("Introduzca la antigüedad");

    let empleado = new Empleado(nombre, apellidos, nif, Number(edad), puesto, Number(salario), Number(antigüedad));
    anyadirEmpleado(empleado);

    document.getElementById("divEmple").innerHTML = "";
    muestraWeb();
}

let btnAnyadirNuevoEmp = document.getElementById("anyadeEmpleForm");
btnAnyadirNuevoEmp.addEventListener("click", nuevoEmpleadoWeb)

let emp1 = new Empleado("Leo", "Coves", "11111111A", 19, "Developer", 2500, 4);
let emp2 = new Empleado("Alex", "Martinez", "2222222B", 18, "Cibersecurity", 1200, 2);

anyadirEmpleado(emp1);
anyadirEmpleado(emp2);

muestraWeb();
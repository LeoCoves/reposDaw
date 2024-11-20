'use strict';
let empleados = [];
let idEmpleado = 0;

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

    let titEmple = document.createElement("h1");
    titEmple.id = "tituloH1";
    titEmple.textContent = "Listado de Empleados";
    divEmple.appendChild(titEmple);

    let listEmple = document.createElement("ol");
    listEmple.id = "listaOrd";
    listEmple.className = "rounded-list";
    

    empleados.forEach(empleado => {
        let liEmp = muestraEmpleado(empleado);
        listEmple.appendChild(liEmp);
    });

    divEmple.appendChild(listEmple);
}

function muestraEmpleado(empleado){
    let liEmp = document.createElement("li");
    liEmp.id = "li" + empleado.id;

    let divEmp = document.createElement("div");
    divEmp.id = empleado.id;
    divEmp.className = "empleado";
    

    let pNomApe = document.createElement("p");
    pNomApe.textContent = empleado.nombre + " " + empleado.apellidos;
    divEmp.appendChild(pNomApe);

    let pNif = document.createElement("p");
    pNif.textContent = "NIF: " + empleado.nif;
    divEmp.appendChild(pNif);

    let pEdad = document.createElement("p");
    pEdad.textContent = "Edad: " + empleado.edad;
    divEmp.appendChild(pEdad);

    let pPuesto = document.createElement("p");
    pPuesto.textContent = "Puesto: " + empleado.puesto; 
    divEmp.appendChild(pPuesto);

    let pSalario = document.createElement("p");
    pSalario.textContent = "Salario: " + empleado.salario;
    divEmp.appendChild(pSalario);

    let pAntigüedad = document.createElement("p");
    pAntigüedad.textContent = "Antigüedad: " + empleado.antigüedad;
    divEmp.appendChild(pAntigüedad);

    let btnEditar = document.createElement("button");
    btnEditar.id = "bEdit" + empleado.id;
    btnEditar.textContent = "Editar";

    let editarBoton = new EditarHandle();
    editarBoton.empleado = empleado;
    btnEditar.addEventListener("click", editarBoton);
    divEmp.appendChild(btnEditar);

    let btnBorrar = document.createElement("button");
    btnBorrar.id = "bBorr" + empleado.id;
    btnBorrar.textContent = "Borrar";

    let borrarBoton = new borrarHandle();
    borrarBoton.empleado = empleado;
    btnBorrar.addEventListener("click", borrarBoton);
    divEmp.appendChild(btnBorrar);

    liEmp.appendChild(divEmp);
    return liEmp;
}

function EditarHandle(){
    this.handleEvent = function(){
        let nombre = prompt("Introduce el nombre", this.empleado.nombre);
        let apellidos = prompt("Introduce los apellidos", this.empleado.apellidos);
        let nif = prompt("Introduce el nif", this.empleado.nif);
        let edad = prompt("Introduce la edad", this.empleado.edad);
        let puesto = prompt("Introduce el puesto", this.empleado.puesto);
        let salario = prompt("Introduce el salario", this.empleado.salario);
        let antigüedad = prompt("Introduce la antigüedad", this.empleado.antigüedad);
        
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
    let nombre = prompt("Introduce el nombre");
    let apellidos = prompt("Introduce los apellidos");
    let nif = prompt("Introduce el nif");
    let edad = prompt("Introduce la edad");
    let puesto = prompt("Introduce el puesto");
    let salario = prompt("Introduce el salario");
    let antigüedad = prompt("Introduce la antigüedad");
    
    let emp = new Empleado(nombre, apellidos, nif, Number(edad), puesto, Number(salario), Number(antigüedad))
    anyadirEmpleado(emp);

    document.getElementById("divEmple").innerHTML = "";
    muestraWeb();
}

let btnNewEmp = document.getElementById("anyadeEmpleForm");
btnNewEmp.addEventListener("click", nuevoEmpleadoWeb);


let emp1 = new Empleado("Leo", "Coves", "1111111A", 19, "Developer", 2500, 5);
let emp2 = new Empleado("Alex", "Martinez", "2222222B", 12, "Becarios", 1200, 5)

anyadirEmpleado(emp1);
anyadirEmpleado(emp2);

muestraWeb();
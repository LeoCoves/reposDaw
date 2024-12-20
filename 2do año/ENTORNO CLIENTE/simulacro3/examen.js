'use strict'

let coches = [];

function Coche(marca, modelo, puertas=5, potencia=120, plazas=5, fecha, ...accesorios){
    
    this.marca = String(marca);
    if(this.marca === undefined)
        this.marca = "No definida";
    
    this.modelo = String(modelo);
    if(this.modelo === undefined)
        this.modelo = "No definido";

    this.puertas = puertas;
    if(typeof puertas !== "number")
        this.puertas = 3;

    this.potencia = potencia;
    if(typeof potencia !== "number")
        this.potencia = 120;

    this.plazas = plazas;
    if(typeof plazas !== "number")
        this.plazas = 5;

    this.fecha = Date.parse(fecha);
    if(isNaN(this.fecha))
        this.fecha = Date.now();

    if(accesorios.length === 0)
        this.accesorios = [];
    else
        this.accesorios = accesorios.map(acc => acc.toLowerCase());

    //Metodos
    this.mostrarCoche = function(){
        let fecha = new Date(this.fecha).toLocaleDateString();
        return  "COCHE: " + this.marca + " " + this.modelo +
                "\nPUERTAS: " + this.puertas +
                "\nPOTENCIA: " + this.potencia +
                "\nPLAZAS: " + this.plazas +
                "\nF.VENTA: " + fecha +
                "\nACCESORIOS: " + this.mostrarAccesorios();
    }

    this.mostrarAccesorios = function(){
        let texto = "";
        accesorios.forEach(accesorio => {
            texto += "\n- " + accesorio.toLowerCase();
        });
        return texto;
    }

    this.actualizarMarcaModelo = function(marca, modelo){
        this.marca = marca;
        this.modelo = modelo;
    }

    this.actualizarPuertasPotenciaPlazas = function(puertas, potencia, plazas){
        if(typeof puertas === "number")
            this.puertas = puertas;
        if(typeof potencia === "number")
            this.potencia = potencia;
        if(typeof plazas === "number")
            this.plazas = plazas;
    }

    this.actualizarFecha = function(fecha){
        if(!isNaN(Date.parse(fecha)))
            this.fecha = Date.parse(fecha);
    }

    this.anyadirAccesorios = function(...accesorios){
        accesorios.forEach(accNew => {
            if(this.accesorios.indexOf(accNew) === -1)
                this.accesorios.push(accNew);
        });
    }

    this.borrarAccesorios = function(...accesorios){
        accesorios.forEach(accBorrar => {
            let pos = this.accesorios.indexOf(accBorrar);
            if(pos !== -1){
                this.accesorios.splice(pos, 1);
            }
        });
    }

    this.ordenarArrayAccesorios = function(){
        this.accesorios = this.accesorios.sort();
    }
}

function anyadirCoche(car){
    coches.push(car);
}

function mostrarFechaVenta(){
    return coches.reduce((acc, coche) => {
        let agroup = new Date(coche.fecha).toLocaleDateString();
        if(!acc[agroup])
            acc[agroup] = 0;
        acc[agroup] += 1;
        return acc;
    }, {})
}

function filtrarCoche({mark, model, npuertas, potDesde, nplazas, ...acces}){
    if(mark !== undefined){
        if(mark.toLowerCase() !== coche.marca.toLowerCase()){
            return false;
        }
    }
    if(model !== undefined){
        
    }
}


let car1 = new Coche('citroën', 'c4', 4, 120, 5, '2022-11-09', 'ELevalunas', 'cierre', 'climatizador');
let car2 = new Coche('seat', 'ibiza', 5, 110, 5, '2022-11-09', 'elevalunas', 'cierre');
let car3 = new Coche('audi', 'a4', 5, 180, 5, '2022-09-09', 'elevalunas', 'cierre');
let car4 = new Coche('renault', 'vel satis', 3, 200, 4, '2022-08-09', 'elevalunas', 'cierre');

anyadirCoche(car1);
anyadirCoche(car2);
anyadirCoche(car3);
anyadirCoche(car4);

console.log(car1.accesorios[0]);

console.log(car1.mostrarCoche())
console.log(car2.mostrarCoche())
console.log(car3.mostrarCoche())
console.log(car4.mostrarCoche())

let res = mostrarFechaVenta();
console.log(res);


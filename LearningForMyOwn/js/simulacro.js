'use strict'

let ordenadores = [];
let idOrdenador = 0;

// function Ordenadores(ordenadores, fechaAlta = 1){
//     this.ordenadores = ordenadores;
    
//     this.ordenadores.ordenador.fecha.indexOf()
// }

function Ordenador(marca, modelo, ram=16, disco=256, pulgadas=15.6, fecha, ...accesorios){

    //Propiedades
    //Marca
    this.marca = marca;
    if(marca === Number){
        this.marca = undefined;
    }


    //Modelo
    this.modelo = modelo;
    if(modelo === Number){
        modelo = undefined;
    }

    //Ram
    if(ram !== Number){
        this.ram = 16;
    }
    this.ram = ram;

    //Disco
    if(disco !== Number){
        disco = 256;
    }
    this.disco = disco;
    

    //Pulgadas
    if(pulgadas !== Number){
        pulgadas = 15.6;
    }
    this.pulgadas = pulgadas;

    //Fecha
    this.fecha = new Date(fecha);
    if(isNaN(this.fecha)){
        this.fecha = Date.now();
    }

    //Accesorios
    if(accesorios.length === 0){
        this.accesorios = [];
    }
    else{
        this.accesorios = [...accesorios];
    }


    //Metodos
    this.mostrarOrdenador = function(){
        let texto = "";

        for(let i = 0; i < accesorios.length; i++){
            texto += "\n- " + accesorios[i];
        }

        return "ORDENADOR: " + this.marca + " " + this.modelo +
                "\nRAM: " + this.ram +
                "\nDISCO: " + this.disco +
                "\nPULGADAS: " + this.pulgadas +
                "\nALTA: " + this.fecha.toLocaleString() +
                "\nACCESORIOS:" + texto;
    }

    this.actualizarMarcaModelo = function(marca, modelo){
        this.marca = marca;
        this.modelo = modelo;
    }


    this.actualizarRamDiscoPulgadas = function(ram, disco, pulgadas){
        if(ram === Number){
            this.ram = ram;
        }
        if(disco === Number){
            this.disco = disco;
        }
        if(pulgadas === Number){
            this.pulgadas = pulgadas;
        }
    }

    this.actualizarFecha = function(fecha){
        if(!isNaN(Date.parse(fecha))){
            this.fecha = Date.parse(fecha);
        }
    }


    this.anyadirAccesorios = function(...accesorios){
        
        this.accesorios.forEach(newAccesorio => {
            if(this.accesorios.indexOf(newAccesorio) !== -1){
                this.accesorios.push(newAccesorio);
            }
        });

    }

    this.borrarAccesorios = function(...accesorios){
        this.accesorios.forEach(lessAccesorio => {
            let pos = this.accesorios.indexOf(lessAccesorio);
            if(pos !== -1){
                this.accesorios.splice(pos, 1);
            }
        });
    }  

}

function anyadirOrdenador(ordenador){
    ordenador.id = idOrdenador;
    idOrdenador++;
    ordenadores.push(ordenador);
}

let pc1 = new Ordenador('lenovo', 'legion', 32, 256, 15.6, '2022-11-09', 'ratón', 'teclado');
let pc2 = new Ordenador('hp', 'omen', 32, 256, 15.6, '2022-11-09', 'ratón', 'teclado');
let pc3 = new Ordenador('acer', 'ferrari', 32, 256, 15.6, '2022-09-09', 'ratón', 'teclado');
let pc4 = new Ordenador('msi', 'modern', 32, 256, 15.6, '2022-08-09', 'ratón', 'teclado');

anyadirOrdenador(pc1);
anyadirOrdenador(pc2);
anyadirOrdenador(pc3);
anyadirOrdenador(pc4);

console.log(pc1.mostrarOrdenador());
console.log(pc2.mostrarOrdenador());
console.log(pc3.mostrarOrdenador());
console.log(pc4.mostrarOrdenador());
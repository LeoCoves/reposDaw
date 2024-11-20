let ordenadores = [];

function Ordenador(marca, modelo, ram=16, disco=256, pulgadas=15.6, fecha, ...accesorios){
    
    this.marca = String(marca);
    if(this.marca === undefined){
        this.marca = "No definida";
    }

    this.modelo = String(modelo);
    if(this.modelo === undefined){
        this.modelo = "No definida";
    }

    if(typeof ram !== "Number")
        this.ram = 16;
    else
        this.ram = ram;

    if(typeof disco !== "Number")
        this.disco = 256;
    else
        this.disco = disco;

    if(typeof pulgadas !== "Number")
        this.pulgadas = 15.6;
    else
        this.pulgadas = pulgadas;

    this.fecha = Date.parse(fecha);
    if(isNaN(this.fecha))
        this.fecha = Date.now();

    this.accesorios = [...accesorios];
    if(accesorios.length === 0)
        this.accesorios = [];

    //Metodos
    this.mostrarOrdenador = function(){
        return  "ORDENADOR: " + this.marca + " " + this.modelo +
                "\nRAM: " + this.ram +
                "\nDISCO: " + this.disco +
                "\nPULGADAS: " + this.pulgadas + 
                "\nACCESORIOS: " + this.listarAccesorios();
        return texto;
    }

    this.listarAccesorios = function(){
        let texto = "";
        accesorios.forEach(accesorio => {
            texto += "\n-" + accesorio;
        });
        return texto;
    }

    this.actualizarMarcaModelo = function(marca, modelo){
        this.marca = marca;
        this.modelo = modelo;
    }

    this.actualizarRamDiscoPulgadas = function(ram, disco, pulgadas){
        if(typeof ram === "Number")
            this.ram = ram;

        if(typeof disco === "Number")
            this.disco = disco;

        if(typeof pulgadas === "Number")
            this.pulgadas = pulgadas;
    }

    this.anyadirAccesorios = function(...accesorios){
        accesorios.forEach(accesorioNuevo => {
            if(this.accesorios.indexOf(accesorioNuevo) === -1){
                this.accesorios.push(accesorioNuevo);
            }
        });
    }

    this.borrarAccesorios = function(...accesorios){
        accesorios.forEach(accesorioBorrar => {
            let pos = this.accesorios.indexOf(accesorioBorrar);
            if(pos !== -1){
                this.accesorios.splice(pos, 1);
            }
        });
    }
}

function anyadirOrdenador(pc){
    ordenadores.push(pc);
}

function mostrarFechaAlta(){
    return ordenadores.reduce((acc, ordenador) => {
        let agroup = new Date(ordenador.fecha).toISOString();

        if(!acc[agroup]){
            acc[agroup] = 0;
        }
        acc[agroup] += 1;
        return acc;
    }, {})
    
}


let pc1 = new Ordenador('lenovo', 'legion', 32, 256, 15.6, '2022-11-09', 'ratón', 'teclado');
let pc2 = new Ordenador('hp', 'omen', 32, 256, 15.6, '2022-11-09', 'ratón', 'teclado');
let pc3 = new Ordenador('acer', 'ferrari', 32, 256, 15.6, '2022-09-09', 'ratón', 'teclado');
let pc4 = new Ordenador('msi', 'modern', 32, 256, 15.6, '2022-08-09', 'ratón', 'teclado');

anyadirOrdenador(pc1);
anyadirOrdenador(pc2);
anyadirOrdenador(pc3);
anyadirOrdenador(pc4);

console.log(pc1.mostrarOrdenador())
console.log(pc2.mostrarOrdenador())
console.log(pc3.mostrarOrdenador())
console.log(pc4.mostrarOrdenador())



let res = mostrarFechaAlta();
console.log(res);

let screen = document.getElementById("calc-input");

function show(n){
        if(screen.value === "ERROR BOMBON") 
            screen.value = "";
        // Si el input está vacío y se pulsa un punto, añadimos "0."
        if (n === '.' && screen.value === '') {
            screen.value = '0.';
        }
        // // Si el último carácter es un operador y se pulsa un punto, añadimos "0."
        // else if (n === '.' && /[+\-*/]$/.test(screen.value)) {
        //     screen.value += '0.';
        // }
        // // Evitar múltiples puntos seguidos
        // else if (n === '.' && screen.value.endsWith('.')) {
        //     return;
        // }
        // // Añadir el valor normalmente
        else {
            screen.value += n;
        }
}

function clearScreen(){
    screen.value = "";
}

function clearLastValue(){
    screen.value = screen.value.slice(0, -1);
}

function calculateScreen(){
    try{
        screen.value = eval(screen.value);
    }
    catch{
        screen.value = "ERROR BOMBON";
    }
}
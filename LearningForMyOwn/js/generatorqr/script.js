<script src="https://cdnjs.cloudflare.com/ajax/libs/qrcodejs/1.0.0/qrcode.min.js"></script>
const url = document.generar.value;

let btnGenerar = document.getElementById("btnGenerate");

let QRCode;

btnGenerar.addEventListener("click", function(){
    let QRCodeContainer = document.getElementById("qrCode")

    new QRCode(QRCodeContainer, {
        text: url,           // El texto o URL que se convertirá en QR
        width: 200,          // Ancho del QR
        height: 200,         // Alto del QR
        colorDark: "#000",   // Color oscuro del QR
        colorLight: "#fff",  // Color claro del QR (fondo)
        correctLevel: QRCode.CorrectLevel.H // Nivel de corrección de errores
    })
})
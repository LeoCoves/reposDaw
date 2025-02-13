//Script sacado de foros para poder abrir un offcanvas despues de realizar un agregarAlCarrito
document.addEventListener("DOMContentLoaded", function () {

    function loadAndOpenCart() {
        fetch('/Carrito/VerCarrito')
            .then(response => response.text())
            .then(html => {

                document.getElementById("contenidoCarrito").innerHTML = html;

                var carritoOffcanvas = new bootstrap.Offcanvas(document.getElementById("offcanvasCarrito"));
                carritoOffcanvas.show();
            })
            .catch(error => {
                console.error("Error al cargar el carrito:", error);
                document.getElementById("contenidoCarrito").innerHTML = "<p>Error al cargar el carrito</p>";
            });
    }


    const urlParams = new URLSearchParams(window.location.search);
    const openCarrito = urlParams.get('openCarrito');
    if (openCarrito && openCarrito.toLowerCase() === 'true') {
        console.log("openCarrito=true detectado en la URL. Se intentará abrir el offcanvas.");
        loadAndOpenCart();
    }

    const carritoBtn = document.querySelector('[data-bs-target="#offcanvasCarrito"]');
    if (carritoBtn) {
        carritoBtn.addEventListener("click", function () {
            loadAndOpenCart();
        });
    }

    $(document).on("click", ".btn-agregar-carrito", function (event) {
        event.preventDefault();

        var button = $(this);
        var idProducto = button.data("id");
        var cantidad = 1;

        $.ajax({
            url: "/Carrito/AgregarCarrito",
            type: "POST",
            data: { idProducto: idProducto, cantidad: cantidad },
            success: function () {
                console.log("Producto agregado correctamente. Cargando contenido del carrito...");
                loadAndOpenCart();
            },
            error: function () {
                alert("Error al agregar el producto al carrito.");
            }
        });
    });
});
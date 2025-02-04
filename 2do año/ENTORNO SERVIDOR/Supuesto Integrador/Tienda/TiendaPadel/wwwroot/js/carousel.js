document.addEventListener("DOMContentLoaded", function () {
    let track = document.getElementById("carouselTrack");
    let items = document.querySelectorAll(".carousel-item");
    let index = 0;
    let totalItems = items.length;
    let isScrolling = false; // Evita saltos rápidos

    function scrollToIndex(newIndex) {
        if (isScrolling || newIndex < 0 || newIndex >= totalItems) return;

        isScrolling = true; // Bloquea movimientos rápidos
        index = newIndex;
        let offset = items[index].offsetTop; // Mueve la imagen exacta sin saltos
        track.style.transform = `translateY(-${offset}px)`;

        setTimeout(() => {
            isScrolling = false; // Permite otro movimiento tras la animación
        }, 500); // Tiempo de espera antes de permitir otro scroll
    }

    document.getElementById("carouselContainer").addEventListener("wheel", function (event) {
        if (event.deltaY > 0) {
            scrollToIndex(index + 1); // Baja una imagen
        } else {
            scrollToIndex(index - 1); // Sube una imagen
        }
        event.preventDefault();
    });

    // Para móviles (gestos táctiles)
    let startY = 0;
    document.getElementById("carouselContainer").addEventListener("touchstart", function (event) {
        startY = event.touches[0].clientY;
    });

    document.getElementById("carouselContainer").addEventListener("touchend", function (event) {
        let deltaY = event.changedTouches[0].clientY - startY;
        if (deltaY < -50) {
            scrollToIndex(index + 1);
        } else if (deltaY > 50) {
            scrollToIndex(index - 1);
        }
    });

    document.getElementById("carouselContainer").addEventListener("scroll", function () {
        document.querySelector(".scroll-indicator").style.display = "none";
    });
});
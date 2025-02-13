window.onload = function () {
    // Verifica si el valor "visited" ya está guardado en sessionStorage
    if (!sessionStorage.getItem("visited")) {
        setTimeout(function () {
            document.getElementById("loading-screen").style.display = "none";
            document.getElementById("page-content").style.display = "block";
        }, 3000);

        // Marca al usuario como "visitado" durante la sesión
        sessionStorage.setItem("visited", "true");
    } else {
        document.getElementById("loading-screen").style.display = "none";
        document.getElementById("page-content").style.display = "block";
    }
}
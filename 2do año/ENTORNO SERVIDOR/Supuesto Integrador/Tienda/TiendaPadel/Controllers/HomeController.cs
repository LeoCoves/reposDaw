using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TiendaPadel.Data;
using TiendaPadel.Models;

namespace TiendaPadel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcTiendaContexto _context;

        public HomeController(ILogger<HomeController> logger,
            MvcTiendaContexto context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(int? idCategoria)
        {
            // Busca el empleado correspondiente al usuario actual. Si existe, activa la
            // vista (View) y en caso contrario, se redirige para crear el empleado.
            string? emailUsuario = User.Identity.Name;
            Cliente? cliente = _context.Clientes.Where(e => e.Email == emailUsuario)
            .FirstOrDefault();
            if (User.Identity.IsAuthenticated &&
                User.IsInRole("Usuario") &&
                cliente == null)
            {
                return RedirectToAction("Create", "MisDatos");
            }


            // Obtener los 16 productos más recientes
            var productosRecientes = await _context.Productos
                .Include(e => e.Categoria)
                .Include(e => e.Imagenes)
                .OrderByDescending(p => p.Id) // Ordenar por ID en orden descendente
                .Take(15) // Tomar los 15 primeros
                .ToListAsync();

            return View(productosRecientes); // Pasar los productos a la vista
        }

        [Authorize(Roles = "Usuario")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

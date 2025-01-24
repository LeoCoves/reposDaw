using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TiendaPadel.Data;
using TiendaPadel.Models;

namespace TiendaPadel.Controllers
{
    [Authorize(Roles = "Usuario")]
    public class MisPedidosController : Controller
    {
        private readonly MvcTiendaContexto _context;

        public MisPedidosController(MvcTiendaContexto context)
        {
            _context = context;
        }
        // GET: MisPedidosController
        public async Task<IActionResult> Index()
        {
            var user = User.Identity.Name; 

            if(user == null)
            {
                return Unauthorized();
            }

            // Filtrar los pedidos del usuario actual e incluir relaciones necesarias
            var pedidos = await _context.Pedidos
            .Include(p => p.Cliente)
            .Include(p => p.Estado)
            .Where(p => p.Cliente.Email == user)
            .ToListAsync();

            return View(pedidos);
        }

        // GET: MisPedidosController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
            .Include(p => p.Estado)
            .Include(p => p.Detalles)
            .ThenInclude(d => d.Producto) // Incluir Producto en los Detalles
            .FirstOrDefaultAsync(p => p.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }


        // GET: MisPedidosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MisPedidosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

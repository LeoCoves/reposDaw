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
        public async Task<IActionResult> Index(int? pageNumber, DateTime? fecha, string? strCadenaEstado)
        {
            var user = User.Identity.Name;

            if (user == null)
            {
                return Unauthorized();
            }

            ViewData["BusquedaFecha"] = fecha.HasValue ? fecha.Value.ToString("yyyy-MM-dd") : "";
            ViewData["BusquedaEstado"] = strCadenaEstado;



            // Cargar datos de Pedidos
            var pedidos = from s in _context.Pedidos
                .OrderByDescending(p => p.Id)
                .Include(p => p.Detalles)
                    .ThenInclude(d => d.Producto) // Incluir el producto dentro del detalle
                        .ThenInclude(prod => prod.Imagenes)
                .Include(p => p.Cliente)
                .Include(p => p.Estado)
                .Where(p => p.Cliente.Email == user && p.Anulado == null)
                          select s;

            // Filtrar por fecha si se proporciona
            if (fecha.HasValue)
            {
                pedidos = pedidos.Where(s => s.Fecha.Date == fecha.Value.Date);
            }

            if (strCadenaEstado != null)
            {
                switch (strCadenaEstado)
                {
                    case "Pendiente":
                        pedidos = pedidos.Where(s => s.Estado.Descripcion == "Pendiente");
                        break;
                    case "Realizado":
                        pedidos = pedidos.Where(s => s.Estado.Descripcion == "Realizado");
                        break;
                        // "Todos" no necesita filtro adicional
                }
            }
            

            int pageSize = 8;
            return View(await PaginatedList<Pedido>.CreateAsync(pedidos.AsNoTracking(),
            pageNumber ?? 1, pageSize));
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
                    .ThenInclude(d => d.Producto)
                        .ThenInclude(prod => prod.Imagenes) // 🔹 Incluye las imágenes correctamente
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }


        // GET: MisPedidosController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Estado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Obtener los detalles relacionados con el pedido
            var detalles = _context.Detalles.Where(d => d.PedidoId == id);

            // Eliminar los detalles
            _context.Detalles.RemoveRange(detalles);

            // Obtener el pedido
            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido != null)
            {
                pedido.Anulado = DateTime.Now;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Acción para volver a agregar un pedido al carrito
        public async Task<IActionResult> VolverACarrito(int id)
        {
            // Buscar el pedido y sus detalles
            var pedido = await _context.Pedidos
                .Include(p => p.Detalles) // Incluir los detalles del pedido
                .ThenInclude(d => d.Producto) // Si necesitas incluir información del producto
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pedido == null)
            {
                return NotFound(); // Si el pedido no existe, devolvemos un error
            }

            // Crear una lista para pasar los productos al carrito
            var productosCarrito = pedido.Detalles.Select(detalle => new
            {
                ProductoId = detalle.ProductoId,
                Cantidad = detalle.Cantidad,
                Precio = detalle.Precio
            }).ToList();

            // Guardar la lista en TempData para enviarla al controlador del carrito
            TempData["ProductosCarrito"] = System.Text.Json.JsonSerializer.Serialize(productosCarrito);

            // Redirigir al controlador del carrito para procesar los productos
            return RedirectToAction("Index", "Carrito");
        }
    }
}

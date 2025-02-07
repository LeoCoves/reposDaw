using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaPadel.Data;
using TiendaPadel.Models;

namespace TiendaPadel.Controllers
{
    [Authorize(Roles = "Usuario")]
    public class CarritoController : Controller
    {
        private readonly MvcTiendaContexto _context;

        public CarritoController(MvcTiendaContexto context)
        {
            _context = context;
        }

        //Get Carrito
        public async Task<IActionResult> Index(int? id)
        {
            if (id.HasValue)
            {
                var pedidoExistente = await _context.Pedidos
                    .Include(p => p.Detalles)
                    .FirstOrDefaultAsync(p => p.Id == id.Value);

                if (pedidoExistente == null)
                {
                    return NotFound(); 
                }
                HttpContext.Session.SetString("NumPedido", id.Value.ToString());
            }

            string? strNumPedido = HttpContext.Session.GetString("NumPedido");

            if (string.IsNullOrEmpty(strNumPedido))
            {
                return RedirectToAction("Index", "Escaparate");
            }

            int numPedido = int.Parse(strNumPedido);

            var pedido = await _context.Pedidos
             .Where(p => p.Id == numPedido)
             .Include(p => p.Detalles)
                 .ThenInclude(d => d.Producto)
                     .ThenInclude(p => p.Imagenes) // 🔹 Agregamos las imágenes de cada producto
             .Include(p => p.Cliente)
             .Include(p => p.Estado)
             .FirstOrDefaultAsync();


            if (pedido == null)
            {
                return RedirectToAction("Index", "Escaparate");
            }

            ViewData["NumPedido"] = numPedido;

            return View(pedido); 
        }

        public async Task<IActionResult> VerCarrito(int? id)
        {

            if (id.HasValue)
            {
                var pedidoExistente = await _context.Pedidos
                    .Include(p => p.Detalles)
                    .FirstOrDefaultAsync(p => p.Id == id.Value);

                if (pedidoExistente == null)
                {
                    return PartialView("CarritoVacio");
                }
                HttpContext.Session.SetString("NumPedido", id.Value.ToString());
            }

            string? strNumPedido = HttpContext.Session.GetString("NumPedido");

            if (string.IsNullOrEmpty(strNumPedido))
            {
                return PartialView("CarritoVacio");
            }

            int numPedido = int.Parse(strNumPedido);

            var pedido = await _context.Pedidos
               .Where(p => p.Id == numPedido)
               .Include(p => p.Detalles)
                   .ThenInclude(d => d.Producto)
                       .ThenInclude(p => p.Imagenes)
               .Include(p => p.Cliente)
               .Include(p => p.Estado)
               .FirstOrDefaultAsync();

            if (pedido == null || !pedido.Detalles.Any())
            {
                return PartialView("CarritoVacio");
            }

            return PartialView("VerCarrito", pedido);
        }


        // Acción ConfirmarPedido
        public async Task<IActionResult> ConfirmarPedido(int? id)
        {
            string? strNumPedido = HttpContext.Session.GetString("NumPedido");

            if (strNumPedido == null || int.Parse(strNumPedido) != id)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido == null)
            {
                return NotFound();
            }

            pedido.EstadoId = 2;
            pedido.Confirmado = DateTime.Now;
            pedido.Cobrado = DateTime.Now;

            _context.Update(pedido);
            await _context.SaveChangesAsync();

            HttpContext.Session.Remove("NumPedido");
            return RedirectToAction("Index", "Escaparate");
        }

        // Acción CarritoVacio
        public async Task<IActionResult> CarritoVacio()
        {
            return View();
        }

        // Acción EliminarLinea
        public async Task<IActionResult> EliminarLinea(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            string? strNumPedido = HttpContext.Session.GetString("NumPedido");

            if (string.IsNullOrEmpty(strNumPedido) || !int.TryParse(strNumPedido, out int numPedido))
            {
                return BadRequest("Número de pedido no válido.");
            }

            var pedido = await _context.Pedidos
                .Include(p => p.Detalles) // Cargar los detalles del pedido
                .FirstOrDefaultAsync(p => p.Id == numPedido);

            if (pedido == null)
            {
                return NotFound();
            }

            var detalle = await _context.Detalles.FindAsync(id);

            if (detalle != null)
            {
                _context.Detalles.Remove(detalle);
                await _context.SaveChangesAsync();
            }

            // Recargar el pedido con los detalles actualizados desde la base de datos
            pedido = await _context.Pedidos
                .Include(p => p.Detalles)
                .FirstOrDefaultAsync(p => p.Id == numPedido);

            // Verificar si el pedido quedó sin detalles después de la eliminación
            if (pedido != null && !pedido.Detalles.Any())
            {
                _context.Pedidos.Remove(pedido);
                await _context.SaveChangesAsync(); // Guardar eliminación del pedido
            }

            return RedirectToAction("Index");
        }

        // Acción MasCantidad
        public async Task<IActionResult> MasCantidad(int? id)
        {
            var detalle = await _context.Detalles.FindAsync(id);

            if (detalle != null)
            {
                detalle.Cantidad++;
                _context.Update(detalle);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        // Acción MenosCantidad
        public async Task<IActionResult> MenosCantidad(int? id)
        {
            var detalle = await _context.Detalles.FindAsync(id);

            if (detalle != null && detalle.Cantidad > 1)
            {
                detalle.Cantidad--;
                _context.Update(detalle);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}


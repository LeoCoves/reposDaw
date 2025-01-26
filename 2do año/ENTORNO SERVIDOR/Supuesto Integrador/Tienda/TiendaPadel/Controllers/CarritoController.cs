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
            // Si se proporciona un ID, configuramos este pedido como el actual en la sesión
            if (id.HasValue)
            {
                // Verificar si el pedido existe en la base de datos
                var pedidoExistente = await _context.Pedidos
                    .Include(p => p.Detalles)
                    .FirstOrDefaultAsync(p => p.Id == id.Value);

                if (pedidoExistente == null)
                {
                    return NotFound(); // Si el pedido no existe, mostramos un error
                }

                // Actualizar el número de pedido en la sesión
                HttpContext.Session.SetString("NumPedido", id.Value.ToString());
            }

            string? strNumPedido = HttpContext.Session.GetString("NumPedido");

            if (string.IsNullOrEmpty(strNumPedido))
            {
                // Si no hay un pedido en la sesión, redirige a una vista que indique que el carrito está vacío
                return RedirectToAction("CarritoVacio");
            }

            int numPedido = int.Parse(strNumPedido);

            var pedido = await _context.Pedidos
                .Where(p => p.Id == numPedido)
                .Include(p => p.Detalles)
                .ThenInclude(d => d.Producto)
                .Include(p => p.Cliente) // Incluye el cliente
                .Include(p => p.Estado) // Incluye el estado del pedido
                .FirstOrDefaultAsync();

            if (pedido == null)
            {
                return RedirectToAction("CarritoVacio");
            }

            ViewData["NumPedido"] = numPedido;

            return View(pedido); // Pasa el modelo completo de Pedido a la vista
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
            var detalle = await _context.Detalles.FindAsync(id);

            if (detalle != null)
            {
                _context.Detalles.Remove(detalle);
                await _context.SaveChangesAsync();
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


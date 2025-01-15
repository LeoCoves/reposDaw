using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TiendaPadel.Data;
using TiendaPadel.Models;

namespace TiendaPadel.Controllers
{
    
    public class EscaparateController : Controller
    {
        private readonly MvcTiendaContexto _context;
        public EscaparateController(MvcTiendaContexto context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? idCategoria)
        {
            var categorias = await _context.Categorias
                .OrderBy(c => c.Descripcion)
                .ToListAsync();

            ViewData["Categorias"] = categorias;


            // Cargar datos de los avisos
            var productos = _context.Productos
                .Include(p => p.Categoria)
                .AsQueryable();


            if (idCategoria.HasValue)
            {
                productos = productos.Where(p => p.CategoriaId == idCategoria.Value);
            }

            return View(await productos.ToListAsync());
        }


        // GET: Escaparate/AgregarCarrito
        public async Task<IActionResult> AgregarCarrito(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
               .Include(p => p.Categoria)
               .FirstOrDefaultAsync(m => m.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        //POST: Escaparate/Agregar Carrito
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarCarrito(int idProducto, int cantidad)
        {
            // Obtener el cliente autenticado
            var usuarioId = User.Identity?.Name; // Asume que el nombre de usuario está relacionado con el cliente
            var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Email == usuarioId);

            if (cliente == null)
            {
                return NotFound();
            }

            // Obtener el número de pedido desde la sesión
            string? strNumPedido = HttpContext.Session.GetString("NumPedido");

            // Si no hay un pedido en la sesión, creamos uno nuevo
            if (string.IsNullOrEmpty(strNumPedido))
            {
                var nuevoPedido = new Pedido
                {
                    ClienteId = cliente.Id, // Asigna el cliente autenticado
                    EstadoId = 1,           // En proceso
                    Fecha = DateTime.Now
                };

                _context.Pedidos.Add(nuevoPedido);
                await _context.SaveChangesAsync();

                // Guardamos el ID del nuevo pedido en la sesión
                HttpContext.Session.SetString("NumPedido", nuevoPedido.Id.ToString());
                strNumPedido = nuevoPedido.Id.ToString();
            }

            int numPedido = int.Parse(strNumPedido);

            // Verificar si el producto ya está en el carrito
            var detalleExistente = await _context.Detalles
                .FirstOrDefaultAsync(d => d.PedidoId == numPedido && d.ProductoId == idProducto);

            if (detalleExistente != null)
            {
                // Si el producto ya está en el carrito, aumentamos la cantidad
                detalleExistente.Cantidad += cantidad;
                _context.Update(detalleExistente);
            }
            else
            {
                // Si el producto no está en el carrito, lo agregamos como nuevo detalle
                var detalle = new Detalle
                {
                    PedidoId = numPedido,
                    ProductoId = idProducto,
                    Cantidad = cantidad,
                    Precio = (await _context.Productos.FindAsync(idProducto)).Precio
                };

                _context.Detalles.Add(detalle);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Carrito"); // Redirige al carrito para ver el contenido
        }
    }
}

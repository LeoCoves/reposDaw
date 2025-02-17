using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TiendaPadel.Data;
using TiendaPadel.Migrations;
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
        public async Task<IActionResult> Index(int? idCategoria, int? pageNumber)
        {
            // Cargar datos de Pedidos
            var productos = from s in _context.Productos
                            .OrderByDescending(p => p.Id)
                            .Include(p => p.Categoria)
                            .Include(p => p.Imagenes)
                            .AsQueryable()
                          select s;

            var categorias = await _context.Categorias
                .ToListAsync();

            ViewData["Categorias"] = categorias;

            if (idCategoria.HasValue)
            {
                productos = productos.Where(p => p.CategoriaId == idCategoria.Value);
            }


            int pageSize = 20;
            return View(await PaginatedList<Producto>.CreateAsync(productos.AsNoTracking(),
            pageNumber ?? 1, pageSize));
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
               .Include(p => p.Imagenes)
               .FirstOrDefaultAsync(m => m.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            var productosRelacionados = _context.Productos
                .Where(p => p.CategoriaId == producto.CategoriaId && p.Id != id)
                .Include(p => p.Imagenes)
                .Take(12) 
                .ToList();

            var viewModel = new AgregarCarritoViewModel
            {
                ProductoActual = producto,
                ProductosRelacionados = productosRelacionados
            };

            return View(viewModel);
        }

        [Authorize(Roles = "Usuario")]
        //POST: Escaparate/Agregar Carrito
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarCarrito(int idProducto, int cantidad)
        {
            var usuarioId = User.Identity?.Name; 
            var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Email == usuarioId);

            if (cliente == null)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            
            string? strNumPedido = HttpContext.Session.GetString("NumPedido");


            int numPedido;

            if (string.IsNullOrEmpty(strNumPedido) || !int.TryParse(strNumPedido, out numPedido))
            {
                // Si no hay pedido en sesión o el ID no es válido, crear uno nuevo
                var nuevoPedido = new Pedido
                {
                    ClienteId = cliente.Id,
                    EstadoId = 1,
                    Fecha = DateTime.Now
                };

                _context.Pedidos.Add(nuevoPedido);
                await _context.SaveChangesAsync();

                // Guardar el nuevo número de pedido en la sesión
                numPedido = nuevoPedido.Id;
                HttpContext.Session.SetString("NumPedido", numPedido.ToString());
            }
            else
            {
                // Verificar si el pedido aún existe en la base de datos
                var pedidoExistente = await _context.Pedidos.FindAsync(numPedido);
                if (pedidoExistente == null)
                {
                    // Si el pedido fue eliminado, crear uno nuevo
                    var nuevoPedido = new Pedido
                    {
                        ClienteId = cliente.Id,
                        EstadoId = 1,
                        Fecha = DateTime.Now
                    };

                    _context.Pedidos.Add(nuevoPedido);
                    await _context.SaveChangesAsync();

                    numPedido = nuevoPedido.Id;
                    HttpContext.Session.SetString("NumPedido", numPedido.ToString());
                }
            }


            var detalleExistente = await _context.Detalles
                .FirstOrDefaultAsync(d => d.PedidoId == numPedido && d.ProductoId == idProducto);

            if (detalleExistente != null)
            {
                detalleExistente.Cantidad += cantidad;
                _context.Update(detalleExistente);
            }
            else
            {
                var producto = await _context.Productos.FindAsync(idProducto);
                if (producto == null)
                {
                    return NotFound();
                }

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

            return RedirectToAction("Index", "Escaparate", new { openCarrito = true });
        }
    }
}

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
                            .AsQueryable()
                          select s;

            var categorias = await _context.Categorias
                .OrderBy(c => c.Descripcion)
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
               .FirstOrDefaultAsync(m => m.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            var productosRelacionados = _context.Productos
                .Where(p => p.CategoriaId == producto.CategoriaId && p.Id != id)
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

            
            if (string.IsNullOrEmpty(strNumPedido))
            {
                var nuevoPedido = new Pedido
                {
                    ClienteId = cliente.Id, 
                    EstadoId = 1,           
                    Fecha = DateTime.Now
                };

                _context.Pedidos.Add(nuevoPedido);
                await _context.SaveChangesAsync();

                
                HttpContext.Session.SetString("NumPedido", nuevoPedido.Id.ToString());
                strNumPedido = nuevoPedido.Id.ToString();
            }

            int numPedido = int.Parse(strNumPedido);

           
            var detalleExistente = await _context.Detalles
                .FirstOrDefaultAsync(d => d.PedidoId == numPedido && d.ProductoId == idProducto);

            if (detalleExistente != null)
            {
                detalleExistente.Cantidad += cantidad;
                _context.Update(detalleExistente);
            }
            else
            {
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

            return RedirectToAction("Index", "Carrito"); 
        }
    }
}

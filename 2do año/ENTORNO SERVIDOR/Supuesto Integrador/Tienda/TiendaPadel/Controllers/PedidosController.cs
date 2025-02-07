using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TiendaPadel.Data;
using TiendaPadel.Models;

namespace TiendaPadel.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class PedidosController : Controller
    {
        private readonly MvcTiendaContexto _context;

        public PedidosController(MvcTiendaContexto context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index(int? pageNumber, DateTime? fecha, string? strCadenaUsuario, string? strCadenaEstado)
        {
            ViewData["BusquedaFecha"] = fecha.HasValue ? fecha.Value.ToString("yyyy-MM-dd") : "";
            ViewData["BusquedaUsuario"] = strCadenaUsuario;
            ViewData["BusquedaEstado"] = strCadenaEstado;

            // Cargar datos de Pedidos e incluir Detalles, Productos e Imagenes
            var pedidos = _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Estado)
                .Include(p => p.Detalles)
                    .ThenInclude(d => d.Producto) // Incluir el producto dentro del detalle
                        .ThenInclude(prod => prod.Imagenes) // Incluir las imágenes del producto
                .OrderByDescending(p => p.Id)
                .AsQueryable();

            // Filtrar por fecha si se proporciona
            if (fecha.HasValue)
            {
                pedidos = pedidos.Where(s => s.Fecha.Date == fecha.Value.Date);
            }

            // Filtrar por usuario
            if (!string.IsNullOrEmpty(strCadenaUsuario))
            {
                pedidos = pedidos.Where(s => s.Cliente.Nombre == strCadenaUsuario);
            }

            // Filtrar por estado
            if (!string.IsNullOrEmpty(strCadenaEstado))
            {
                switch (strCadenaEstado)
                {
                    case "Pendiente":
                        pedidos = pedidos.Where(s => s.Estado.Descripcion == "Pendiente");
                        break;
                    case "Realizado":
                        pedidos = pedidos.Where(s => s.Estado.Descripcion == "Realizado");
                        break;
                }
            }



            int pageSize = 8;
            return View(await PaginatedList<Pedido>.CreateAsync(pedidos.AsNoTracking(),
            pageNumber ?? 1, pageSize));
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nombre");
            ViewData["EstadoId"] = new SelectList(_context.Estados, "Id", "Descripcion");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,Confirmado,Preparado,Enviado,Cobrado,Devuelto,Anulado,ClienteId,EstadoId")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nombre", pedido.ClienteId);
            ViewData["EstadoId"] = new SelectList(_context.Estados, "Id", "Descripcion", pedido.EstadoId);
            return View(pedido);
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nombre", pedido.ClienteId);
            ViewData["EstadoId"] = new SelectList(_context.Estados, "Id", "Descripcion", pedido.EstadoId);
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,Confirmado,Preparado,Enviado,Cobrado,Devuelto,Anulado,ClienteId,EstadoId")] Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nombre", pedido.ClienteId);
            ViewData["EstadoId"] = new SelectList(_context.Estados, "Id", "Descripcion", pedido.EstadoId);
            return View(pedido);
        }

        // GET: Pedidos/Delete/5
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
            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido != null)
            {
                pedido.Anulado = DateTime.Now;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedidos.Any(e => e.Id == id);
        }
    }
}

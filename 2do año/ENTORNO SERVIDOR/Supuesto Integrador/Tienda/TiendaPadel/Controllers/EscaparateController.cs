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
            //// Ordenar descendente por FechaAviso
            ////productos = productos.OrderByDescending(s => s.FechaAviso);
            //// Para buscar avisos por nombre de empleado en la lista de valores
            ////if (!String.IsNullOrEmpty(strCadenaBusqueda))
            ////{
            ////    avisos = avisos.Where(s => s.Empleado.Nombre.Contains(strCadenaBusqueda));
            ////}
            //// Para filtrar avisos por tipo de avería
            //if (idCategoria == null)
            //{
            //    ViewData["Categorias"] = new SelectList(_context.Categorias, "Id",
            //    "Descripcion");
            //}
            //else
            //{
            //    ViewData["Categorias"] = new SelectList(_context.Categorias, "Id",
            //    "Descripcion", idCategoria);
            //    productos = productos.Where(x => x.CategoriaId == idCategoria);
            //}
            //productos = productos.Include(a => a.Categoria);
            //return View(await productos.AsNoTracking().ToListAsync());

            if (idCategoria.HasValue)
            {
                productos = productos.Where(p => p.CategoriaId == idCategoria.Value);
            }

            return View(await productos.ToListAsync());
        }
    }
}

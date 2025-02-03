using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TiendaPadel.Data;
using TiendaPadel.Models;

namespace TiendaPadel.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ProductosController : Controller
    {
        private readonly MvcTiendaContexto _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductosController(MvcTiendaContexto context, IWebHostEnvironment HostEnvironment)
        {
            _context = context;
            _webHostEnvironment = HostEnvironment;
        }

        // GET: Productos
        public async Task<IActionResult> Index(int? pageNumber, string? strCadenaBusqueda, string? strCadenaCategoria, bool? cadenaEscaparate)
        {
            ViewData["BusquedaActual"] = strCadenaBusqueda;
            ViewData["BusquedaCategoria"] = strCadenaCategoria;
            ViewData["BusquedaEscaparate"] = cadenaEscaparate;

            // Cargar datos de Pedidos
            var productos = from s in _context.Productos.Include(p => p.Categoria).Include(p => p.Imagenes).OrderByDescending(p => p.Id)
                            select s;

            if (!String.IsNullOrEmpty(strCadenaBusqueda))
            {
                productos = productos.Where(s => s.Descripcion.Contains(strCadenaBusqueda));
            }

            if (!String.IsNullOrEmpty(strCadenaCategoria))
            {
                productos = productos.Where(s => s.Categoria.Descripcion.Contains(strCadenaCategoria));
            }

            if (cadenaEscaparate.HasValue)
            {
                productos = productos.Where(s => s.Escaparate == cadenaEscaparate.Value);
            }

            int pageSize = 8;
            return View(await PaginatedList<Producto>.CreateAsync(productos.AsNoTracking(),
            pageNumber ?? 1, pageSize));

        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descripcion");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,Texto,Precio,PrecioCadena,Stock,Escaparate,CategoriaId")] Producto producto, List<IFormFile> imagenes)
        {
            if (ModelState.IsValid)
            {
                producto.Imagenes = new List<ImagenProducto>();

                // Procesar imágenes si se han subido
                if (imagenes != null && imagenes.Any())
                {
                    foreach (var imagen in imagenes)
                    {
                        if (imagen.Length > 0)
                        {
                            // Guardar archivo en wwwroot/imagenes
                            var nombreArchivo = Path.GetFileName(imagen.FileName);
                            var ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagenes", nombreArchivo);

                            using (var stream = new FileStream(ruta, FileMode.Create))
                            {
                                await imagen.CopyToAsync(stream);
                            }

                            // Agregar la imagen a la lista
                            producto.Imagenes.Add(new ImagenProducto { Url = nombreArchivo });
                        }
                    }
                }
                else
                {
                    // Si no hay imágenes, agregar una por defecto
                    producto.Imagenes.Add(new ImagenProducto { Url = "sinImagen.jpg" });
                }

                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descripcion", producto.CategoriaId);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descripcion", producto.CategoriaId);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion,Texto,Precio,PrecioCadena,Stock,Escaparate,Imagen,CategoriaId")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var productoOriginal = await _context.Productos
                        .Include(p => p.Imagenes) // Incluir las imágenes originales
                        .AsNoTracking()
                        .FirstOrDefaultAsync(p => p.Id == id);

                    if (productoOriginal == null) return NotFound();

                    // Mantener las imágenes originales si no se han cambiado
                    if (producto.Imagenes == null || !producto.Imagenes.Any())
                    {
                        producto.Imagenes = productoOriginal.Imagenes;
                    }

                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
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

            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descripcion", producto.CategoriaId);
            return View(producto);

        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Productos");
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }

        public async Task<IActionResult> CambiarImagen(int? id)
        {
            if (id == null || _context.Productos == null)
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

            return View(producto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CambiarImagen(int? ProductoId, IFormFile[] Imagenes)
        {
            if (ProductoId == null || Imagenes == null || Imagenes.Length == 0)
            {
                return NotFound(); // Si no hay ID de producto o imágenes
            }

            var producto = await _context.Productos
                .Include(p => p.Imagenes) // Incluimos las imágenes para poder modificarlas
                .FirstOrDefaultAsync(m => m.Id == ProductoId);

            if (producto == null)
            {
                return NotFound(); // Si no encontramos el producto
            }

            if (ModelState.IsValid)
            {
                // Eliminar todas las imágenes anteriores
                if (producto.Imagenes != null)
                {
                    foreach (var img in producto.Imagenes)
                    {
                        string rutaImagen = Path.Combine(_webHostEnvironment.WebRootPath, "imagenes", img.Url);
                        if (System.IO.File.Exists(rutaImagen))
                        {
                            System.IO.File.Delete(rutaImagen); // Eliminar la imagen del servidor
                        }
                    }

                    // Limpiar la lista de imágenes
                    producto.Imagenes.Clear();
                }

                // Copiar archivos de las nuevas imágenes
                string strRutaImagenes = Path.Combine(_webHostEnvironment.WebRootPath, "imagenes");

                // Asegurarse de que la ruta exista, si no, crearla
                if (!Directory.Exists(strRutaImagenes))
                {
                    Directory.CreateDirectory(strRutaImagenes);
                }

                foreach (var imagen in Imagenes)
                {
                    // Generar nombre único para cada imagen
                    string extension = Path.GetExtension(imagen.FileName);
                    string nombreFichero = $"{producto.Id}-{Guid.NewGuid()}{extension}";
                    string rutaFichero = Path.Combine(strRutaImagenes, nombreFichero);

                    // Guardar la nueva imagen en el servidor
                    using (var fileStream = new FileStream(rutaFichero, FileMode.Create))
                    {
                        await imagen.CopyToAsync(fileStream);
                    }

                    // Crear un nuevo objeto ImagenProducto y agregarlo a la lista de imágenes
                    producto.Imagenes.Add(new ImagenProducto
                    {
                        Url = nombreFichero // La URL es el nombre del archivo
                    });
                }

                try
                {
                    // Guardar los cambios en la base de datos
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    ModelState.AddModelError("", "Error al cargar las imágenes: " + ex.Message);
                    return View(producto); // Regresar a la vista con el error
                }

                return RedirectToAction(nameof(Index)); // Redirigir a la lista de productos
            }

            // Si hay errores en el modelo
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Descripcion", producto.CategoriaId);
            return View(producto);
        }


    }

}

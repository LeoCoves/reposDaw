using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Index()
        {
            var productosEscaparate = await _context.Productos
                .Where(p => p.Escaparate == true)
                .ToListAsync();
            return View(productosEscaparate);
        }
    }
}

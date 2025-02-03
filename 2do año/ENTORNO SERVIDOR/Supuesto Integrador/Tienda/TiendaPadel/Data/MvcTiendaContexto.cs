using Microsoft.EntityFrameworkCore;
using TiendaPadel.Models;

namespace TiendaPadel.Data
{
    public class MvcTiendaContexto : DbContext
    {
        public MvcTiendaContexto(DbContextOptions<MvcTiendaContexto> options)
                : base(options)
        {
        }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Producto>? Productos { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Estado>? Estados { get; set; }
        public DbSet<Pedido>? Pedidos { get; set; }
        public DbSet<Detalle>? Detalles { get; set; }
        public DbSet<ImagenProducto> ImagenesProducto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configurar la relación uno a muchos entre Producto e ImagenProducto
            modelBuilder.Entity<ImagenProducto>()
                .HasOne(i => i.Producto)
                .WithMany(p => p.Imagenes)
                .HasForeignKey(i => i.ProductoId)
                .OnDelete(DeleteBehavior.Cascade); // Si se borra un producto, sus imágenes también

            // Deshabilitar eliminación en cascada en todas las demás relaciones
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                     .SelectMany(e => e.GetForeignKeys()))
            {
                if (relationship.PrincipalEntityType.ClrType != typeof(Producto) ||
                    relationship.DeclaringEntityType.ClrType != typeof(ImagenProducto))
                {
                    relationship.DeleteBehavior = DeleteBehavior.Restrict;
                }
            }
        }
    }
}

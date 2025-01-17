﻿using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Producto>()
            .Property(p => p.Escaparate)
            .HasDefaultValue(false);

            // Deshabilitar la eliminación en cascada en todas las relaciones
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in
            modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}

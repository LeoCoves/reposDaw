namespace TiendaPadel.Models
{
    public class ImagenProducto
    {
        public int Id { get; set; }
        public string Url { get; set; }

        // Clave foránea para Producto
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}

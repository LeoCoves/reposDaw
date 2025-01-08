using System.ComponentModel.DataAnnotations;

namespace TiendaPadel.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La decripción es un campo requerido.")]
        public string? Descripcion { get; set; }

        public ICollection<Producto>? Producto  { get; set; }
    }
}

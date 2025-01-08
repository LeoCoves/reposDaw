using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TiendaPadel.Models
{
    public class Estado
    {
        public int Id { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "La descripcion es un campo requerido")]
        public string? Descripcion {  get; set; }

        public ICollection<Pedido>? Pedidos { get; set; }
    }
}

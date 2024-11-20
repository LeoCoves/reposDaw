using System.ComponentModel.DataAnnotations;

namespace MvcAgenda.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del empleado es un campo requerido")]
        public string? Nombre { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Departamento")]
        public string? DepartamentoId { get; set; }

        public Departamento? Deparatamento { get; set; }
        public ICollection<Tarea>? Tarreas { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace webappacademica1.Models
{
    public class Alumno
    {
        [Key]
        public int idAlumno { get; set; }

        [Required]
        public string codigo { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public string direccion { get; set; }

        public string? telefono { get; set; }  // Acepta NULL como en SQL
    }
}

using System.ComponentModel.DataAnnotations;
namespace webappacademica1.Models
{
    public class Materia
    {
       [Key]

        public int idMateria { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int uv { get; set; }
    }
}

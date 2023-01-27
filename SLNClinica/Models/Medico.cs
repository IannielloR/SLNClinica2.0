using System.ComponentModel.DataAnnotations;

namespace SLNClinica.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Debe ingresar el Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Apellido")]
        public string Apellido { get; set; }

        [RegularExpression(@"^[A-Z]{2}\s+[1-9]{4}$", ErrorMessage = "Solo se aceptan dos letras y cuatro numeros")]
        public int Matricula { get; set; }

    }
}

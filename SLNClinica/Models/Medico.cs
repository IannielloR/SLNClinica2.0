using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLNClinica.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage ="Debe ingresar el Nombre")]
        public string Nombre { get; set; }


        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Debe ingresar el Apellido")]
        public string Apellido { get; set; }


        [RegularExpression(@"^[A-Z]{2}\s+[1-9]{4}$", ErrorMessage = "Solo se aceptan dos letras y cuatro numeros")]
        public int Matricula { get; set; }

    }
}

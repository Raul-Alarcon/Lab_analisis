using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace adsProyecto.Models
{
    [PrimaryKey(nameof(IdProfesor))]
    public class Profesor
    {
        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "El campo es requido")]
        [MaxLength(50, ErrorMessage = "El campo no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo es requido")]
        [MaxLength(50, ErrorMessage = "El campo no puede tener más de 50 caracteres")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [MaxLength(254, ErrorMessage = "El campo no puede tener mas de 254 caracteres")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo valido")]
        public string Correo { get; set; }
    }
}

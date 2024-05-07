using adsProyecto.Validaciones;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace adsProyecto.Models
{
    [PrimaryKey(nameof(IdGrupo))]
    public class Grupo
    {
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int IdGrupo { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int IdCarrera { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int IdMateria { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string cliclo { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string anio { get; set; }

    }
}

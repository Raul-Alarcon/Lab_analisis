using System.ComponentModel.DataAnnotations;

namespace adsProyecto.Models
{
    public class Grupo
    {
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

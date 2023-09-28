using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosAcedemicos.Shared.Entities
{
    public class ProgramaEvento
    {

        public int Id { get; set; }

        [Display(Name = "Nombre del programa")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo nombre del programa es obligatorio")]
        public string Name { get; set; } = null!;

        [Display(Name = "Hora inicio")]
        [MaxLength(10)]
        [Required(ErrorMessage = "La hora de inicio es obligatoria")]
        public string FechaInicio { get; set; } = null!;

        [Display(Name = "Hora Finalización")]
        [MaxLength(10)]
        [Required(ErrorMessage = "La hora de finazalización es obligatoria")]
        public string FechaFinal { get; set; } = null!;

        [Display(Name = "Sesión")]
        [MaxLength(50)]
        [Required(ErrorMessage = "La sesión es obligatoria")]
        public string Ubicacion { get; set; } = null!;

        [Display(Name = "Nombre Ponente")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El nombre del ponente es obligatorio")]
        public string Descripcion { get; set; } = null!;

        [Display(Name = "Tema Tratado")]
        [MaxLength(100)]
        [Required(ErrorMessage = "EL tema tratado en la sesión es obligatorio")]
        public string TemaEvento { get; set; } = null!;

    }
}

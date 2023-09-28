using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosAcedemicos.Shared.Entities
{
    public class EventoAcademico
    {

        public int Id { get; set; }

        [Display(Name = "Nombre del evento")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo nombre del evento es obligatorio")]
        public string Name { get; set; } = null!;

        [Display(Name = "Fecha de inicio")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo fecha de inicio es obligatorio")]
        public string FechaInicio { get; set; } = null!;

        [Display(Name = "Fecha Finalización")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo fecha final es obligatorio")]
        public string FechaFinal { get; set; } = null!;

        [Display(Name = "Ubicación")]
        [MaxLength(50)]
        [Required(ErrorMessage = "La ubicación es obligatorio")]
        public string Ubicacion { get; set; } = null!;

        [Display(Name = "Descripción")]
        [MaxLength(100)]
        [Required(ErrorMessage = "La Descripción es obligatoria")]
        public string Descripcion { get; set; } = null!;

        [Display(Name = "Tema del evento")]
        [MaxLength(100)]
        [Required(ErrorMessage = "EL tema del evento es obligatorio")]
        public string TemaEvento { get; set; } = null!;

    }
}

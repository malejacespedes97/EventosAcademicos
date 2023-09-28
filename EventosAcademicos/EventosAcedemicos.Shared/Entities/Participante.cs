using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosAcedemicos.Shared.Entities
{
    public class Participante
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del participante")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo nombre del participante es obligatorio")]
        public string Name { get; set; } = null!;

        [Display(Name = "Afiliación institucional")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo afiliación institucional es obligatorio")]
        public string Afiliacion { get; set; } = null!;

        [Display(Name = "Area de interes")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo area de interes es obligatorio")]
        public string AreaInteres { get; set; } = null!;

        [Display(Name = "Tipo de participacion")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo tipo participación es obligatorio, recordar que es Ponente o Asistente")]
        public string TipoParticipacion { get; set; } = null!;
    }
}


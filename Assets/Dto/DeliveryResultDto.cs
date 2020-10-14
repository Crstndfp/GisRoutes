using System;
using System.ComponentModel.DataAnnotations;

namespace Assets.Dto
{
    public class DeliveryResultDto
    {
        [Required(ErrorMessage = "NoRegistro is required.")]
        public string NoRegistro { get; set; }
        [Required(ErrorMessage = "CodigoRuta is required.")]
        public string CodigoRuta { get; set; }
        [Required(ErrorMessage = "Fecha is required.")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "IdResultado is required.")]
        public string IdResultado { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Persona { get;set; }
    }
}

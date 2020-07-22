using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assets.Dto
{
    public class DeliveryResultDto
    {
        public string NoRegistro { get; set; }
        public string CodigoRuta { get; set; }
        public DateTime Fecha { get; set; }
        public string IdResultado { get; set; }
        public string Persona { get;set; }
    }
}

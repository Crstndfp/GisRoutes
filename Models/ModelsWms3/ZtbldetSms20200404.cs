using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZtbldetSms20200404
    {
        public string Telefono { get; set; }
        public string Mensaje { get; set; }
        public DateTime? FechaGrabacion { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string Resultado { get; set; }
        public int? CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public string Tipo { get; set; }
    }
}

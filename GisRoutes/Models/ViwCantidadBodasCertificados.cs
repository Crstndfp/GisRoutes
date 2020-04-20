using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ViwCantidadBodasCertificados
    {
        public string NombreDelEvento { get; set; }
        public DateTime? FechaEvento { get; set; }
        public int? CantidadCertificados { get; set; }
        public decimal? MontoCertificados { get; set; }
        public string Descripcion { get; set; }
    }
}

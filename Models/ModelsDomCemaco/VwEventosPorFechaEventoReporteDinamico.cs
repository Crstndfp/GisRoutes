using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class VwEventosPorFechaEventoReporteDinamico
    {
        public string Id { get; set; }
        public string NombreEvento { get; set; }
        public string FechaInscripcion { get; set; }
        public string Tienda { get; set; }
        public DateTime? FechaEvento { get; set; }
        public string NombreNovia { get; set; }
        public string Email { get; set; }
        public string Telefonos { get; set; }
    }
}

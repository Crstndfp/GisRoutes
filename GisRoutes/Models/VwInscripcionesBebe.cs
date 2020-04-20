using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class VwInscripcionesBebe
    {
        public string TiendaInscripcion { get; set; }
        public string IdEvento { get; set; }
        public int? CantListas { get; set; }
        public string NombreDelEvento { get; set; }
        public string Fecha { get; set; }
        public int CodTipo { get; set; }
    }
}

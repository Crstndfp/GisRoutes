using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class VwInscripcionesSinRecoridoBebe
    {
        public string TiendaInscripcion { get; set; }
        public int CodTipo { get; set; }
        public int? Inscripcion { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public string NombreMes { get; set; }
        public string Fecha { get; set; }
    }
}

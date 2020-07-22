using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetFacturaEnvio
    {
        public int CodTipo { get; set; }
        public string NumDocumento { get; set; }
        public int LineaOrig { get; set; }
        public string IdEnvio { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaImp { get; set; }
        public DateTime? FechaEnt { get; set; }
        public string Recibio { get; set; }
    }
}

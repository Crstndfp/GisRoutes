using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblDetRutaRetenido
    {
        public string IdRuta { get; set; }
        public string IdEnvio { get; set; }
        public string Status { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string SerieId { get; set; }
        public string NumeroId { get; set; }
        public string Receptor { get; set; }
        public string Firma { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
    }
}

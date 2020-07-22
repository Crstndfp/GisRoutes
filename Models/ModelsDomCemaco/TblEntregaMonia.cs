using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblEntregaMonia
    {
        public string IdEvento { get; set; }
        public DateTime Fecha { get; set; }
        public string IdPersonal { get; set; }
        public string CodUbicacion { get; set; }
        public string IdEnvio { get; set; }
        public string SerieId { get; set; }
        public string NumeroId { get; set; }
        public string Receptor { get; set; }
        public string Firma { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
    }
}

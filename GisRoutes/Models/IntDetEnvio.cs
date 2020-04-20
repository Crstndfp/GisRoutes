using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class IntDetEnvio
    {
        public string IdEnvio { get; set; }
        public string Tienda { get; set; }
        public int? NoEnvio { get; set; }
        public int NoLinea { get; set; }
        public string Sku { get; set; }
        public string UniMed { get; set; }
        public int? NoTracking { get; set; }
        public Guid? RowGuid { get; set; }
        public string CodEvento { get; set; }
        public decimal? Correlativo { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public string TiendaEnvio { get; set; }
    }
}

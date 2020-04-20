using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class DetEnvio
    {
        public string Tienda { get; set; }
        public decimal NoEnvio { get; set; }
        public int NoLinea { get; set; }
        public string Sku { get; set; }
        public string Unimed { get; set; }
        public int NoTracking { get; set; }
        public Guid Rowguid { get; set; }
        public string CodEvento { get; set; }
        public decimal Correlativo { get; set; }
        public decimal Mes { get; set; }
        public decimal Anio { get; set; }
        public string TiendaEnvio { get; set; }
    }
}

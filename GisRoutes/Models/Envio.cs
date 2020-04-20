using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class Envio
    {
        public string Tienda { get; set; }
        public decimal NoEnvio { get; set; }
        public string CodEvento { get; set; }
        public decimal Correlativo { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Piloto { get; set; }
        public string Status { get; set; }
        public string RecibidoPor { get; set; }
        public DateTime? FechaRecibido { get; set; }
        public string IdenRecPor { get; set; }
        public Guid Rowguid { get; set; }
        public string TiendaEnvio { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class IntEnvio
    {
        public string IdEnvio { get; set; }
        public string Tienda { get; set; }
        public int? NoEnvio { get; set; }
        public string CodEvento { get; set; }
        public decimal? Correlativo { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int Piloto { get; set; }
        public string Status { get; set; }
        public string RecibidoPor { get; set; }
        public DateTime? FechaRecibido { get; set; }
        public string IdenRecPor { get; set; }
        public Guid? RowGuid { get; set; }
        public string TiendaEnvio { get; set; }
        public string StatusEnvio { get; set; }
    }
}

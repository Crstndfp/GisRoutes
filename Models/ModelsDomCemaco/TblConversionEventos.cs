using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class TblConversionEventos
    {
        public string TipoEvento { get; set; }
        public decimal CorreEvento { get; set; }
        public string Tienda { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public DateTime? Fecha { get; set; }
        public string IdEvento { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class RegalosAgregados
    {
        public string Tienda { get; set; }
        public string TipoEvento { get; set; }
        public decimal Mes { get; set; }
        public decimal Anio { get; set; }
        public decimal Correlativo { get; set; }
        public DateTime FechaAgregado { get; set; }
        public int NoRegalo { get; set; }
        public int PersonaAgrega { get; set; }
        public Guid Rowguid { get; set; }
    }
}

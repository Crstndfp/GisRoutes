using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwBodasComprasXelaSku
    {
        public string NombreDelEvento { get; set; }
        public string Sku { get; set; }
        public int? Cantidad { get; set; }
        public decimal? CantidadXPrecio { get; set; }
        public decimal? CostoUnitario { get; set; }
        public DateTime? FechaEvento { get; set; }
    }
}

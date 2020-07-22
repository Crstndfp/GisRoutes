using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ViwVentasTienda
    {
        public string Tienda { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? Monto { get; set; }
    }
}

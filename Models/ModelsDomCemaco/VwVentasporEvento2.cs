using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class VwVentasporEvento2
    {
        public string IdCaja { get; set; }
        public int Transaccion { get; set; }
        public string Sku { get; set; }
        public decimal? Preciodesc { get; set; }
    }
}

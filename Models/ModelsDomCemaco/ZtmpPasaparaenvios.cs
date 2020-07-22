using System;
using System.Collections.Generic;

namespace Models.ModelsDomCemaco
{
    public partial class ZtmpPasaparaenvios
    {
        public TimeSpan IdCaja { get; set; }
        public int Transaccion { get; set; }
        public DateTime? Sku { get; set; }
        public decimal? Preciodesc { get; set; }
    }
}

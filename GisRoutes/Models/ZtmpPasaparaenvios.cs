using System;
using System.Collections.Generic;

namespace GisRoutes.Models
{
    public partial class ZtmpPasaparaenvios
    {
        public TimeSpan IdCaja { get; set; }
        public int Transaccion { get; set; }
        public DateTime? Sku { get; set; }
        public decimal? Preciodesc { get; set; }
    }
}

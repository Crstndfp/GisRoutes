using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class ZVwLbTransaccionesEc
    {
        public string CodTienda { get; set; }
        public string IdAsociado { get; set; }
        public int? CtaEcommerce { get; set; }
        public string Sku { get; set; }
        public string DiaId { get; set; }
        public int? VentUni { get; set; }
        public decimal? VentaVal { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblArticuloImpuesto
    {
        public string Sku { get; set; }
        public string Impuesto { get; set; }
        public decimal ValImpuesto { get; set; }
        public string TipoProd { get; set; }
    }
}

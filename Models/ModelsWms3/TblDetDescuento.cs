using System;
using System.Collections.Generic;

namespace Models.ModelsWms3
{
    public partial class TblDetDescuento
    {
        public string CodTipo { get; set; }
        public int Lista { get; set; }
        public string Sku { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Usuario { get; set; }
    }
}
